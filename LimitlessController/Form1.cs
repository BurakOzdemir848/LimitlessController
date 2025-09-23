using LimitlessController.Core.Interfaces;
using LimitlessController.Core.Models;
using LimitlessController.Core.Services;
using LimitlessController.Infrastructure.Services;
using System.Text.Json;

namespace LimitlessController
{
    public partial class Form1 : Form
    {
        private readonly IConnection _connection;
        private readonly ConverterFactory _factory;
        private readonly MessageService _messageService;

        CancellationTokenSource cts = new CancellationTokenSource();
        bool greenVisible;
        bool loopRunning;

        public Form1(ConverterFactory factory, IConnection connection, MessageService messageService)
        {
            InitializeComponent();
            _factory = factory;
            _connection = connection;
            _messageService = messageService;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void LoadFromTxt()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.txt");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                Config config = JsonSerializer.Deserialize<Config>(json);

                ipBox.Text = config.IP;
                portBox.Text = config.Port;

                keyList.Items.Clear();
                foreach (var key in config.Keys)
                {
                    keyList.Items.Add(key.Key);
                }
            }
            else
            {
                MessageBox.Show("Config.txt not found");
            }
        }


        private async void Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Checked Keys SENT. Wait for {(int)timeoutMsUd.Value}ms to send another!");
            
            if (_connection.IsConnected==false) MessageBox.Show("Not connected to server.");

            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                if (!loopCheck.Checked)
                {
                    if (keyList.CheckedIndices.Count == 0) { MessageBox.Show("Select at least 1 key!"); return; }

                    foreach (ListViewItem item in keyList.CheckedItems)
                    {
                        if (item == null) break;
                        var result = await _messageService.SendAndReceiveAsync(item.Text,
                            (DataFormat)sendFormatCb.SelectedIndex,
                            (DataFormat)responseFormatCb.SelectedIndex,
                            endianCheck.Checked,
                            clrfCheckBox.Checked,
                            (int)timeoutMsUd.Value,
                            token);
                        resultView.Rows.Add(item.Text, result.HexDump, result.Formatted);
                    }
                }
                if (loopRunning)
                {
                    MessageBox.Show("Cancel the active loop");
                    return;
                }
                if (loopCheck.Checked)
                {
                    loopRunning = true;
                    try
                    {
                        while (!token.IsCancellationRequested)
                        {
                            if (keyList.CheckedIndices.Count == 0) { MessageBox.Show("Select at least 1 key!"); return; }
                            foreach (ListViewItem item in keyList.CheckedItems)
                            {
                                if (item == null) break;
                                if (token.IsCancellationRequested) { loopRunning = false; break; }

                                greenVisible = true;
                                colorTimer.Start();
                                loopColor.Invalidate();

                                var result = await _messageService.SendAndReceiveAsync(item.Text,
                                (DataFormat)sendFormatCb.SelectedIndex,
                                (DataFormat)responseFormatCb.SelectedIndex,
                                endianCheck.Checked,
                                clrfCheckBox.Checked,
                                (int)timeoutMsUd.Value,
                                token);

                                resultView.Rows.Add(item.Text, result.HexDump, result.Formatted);
                                await Task.Delay(1000, token);
                            }
                        }
                    }
                    finally { loopRunning = false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void resultView_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            resultView.ScrollBars = ScrollBars.Both;
            resultView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            resultView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            resultView.AllowUserToAddRows = false;
            resultView.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void button1_Click(object sender, EventArgs e) //stop loop btn
        {
            cts?.Cancel();
            loopRunning = false;
            colorTimer.Stop();
            loopColor.Invalidate();
        }

        private async void ConnectBtn_Click(object sender, EventArgs e)
        {
            string ip = ipBox.Text;
            int port = int.Parse(portBox.Text);
            if (await _connection.ConnectAsync(ip, port))
            {
                label3.Text = "CONNECTED";
                label3.BackColor = Color.Green;
                ConnectionTimer.Start();

            }
            else
            {
                label3.Text = "DISCONNECTED";
                label3.BackColor = Color.Red;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadFromTxt();
            ConnectionTimer.Interval = 500;
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            sendFormatCb.SelectedIndex = 4;
            responseFormatCb.SelectedIndex = 4;
            convertReqCb.SelectedIndex = 4;
            convertResultCb.SelectedIndex = 4;

        }

        private void loopCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (allSelect.Checked)
                foreach (ListViewItem item in keyList.Items)
                    item.Checked = true;

            else
                foreach (ListViewItem item in keyList.Items)
                    item.Checked = false;
        }

        private void clearLogBtn_Click_1(object sender, EventArgs e)
        {
            resultView.Rows.Clear();
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loopColor_Paint(object sender, PaintEventArgs e)
        {
            Color panelColor;
            if (loopRunning)
                panelColor = greenVisible ? Color.LightGreen : Color.White;
            else
                panelColor = Color.Red;

            using (SolidBrush brush = new SolidBrush(panelColor))
                e.Graphics.FillRectangle(brush, loopColor.ClientRectangle);

        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            greenVisible = !greenVisible;
            loopColor.Invalidate();
        }


        private void keyDeleteButton_Click(object sender, EventArgs e)
        {
            if (keyList.CheckedItems != null)
                foreach (ListViewItem item in keyList.CheckedItems.Cast<object>().ToArray())
                    keyList.Items.Remove(item);
            else
                MessageBox.Show("Check a key to delete.");

            keyList.Invalidate();
        }

        private void keyAddButton_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = keyTextBox.Text.Trim();
            if (loopRunning == true) MessageBox.Show("Stop the loop before adding a keey");
            else if (!string.IsNullOrEmpty(keyTextBox.Text) && !keyList.Items.ToString().Contains(keyTextBox.Text))
            {
                keyList.Items.Add(keyTextBox.Text);
                keyTextBox.Clear();
            }
            else
                MessageBox.Show("Invalid or duplicate key.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _connection.Disconnect();
            label3.Text = "DISCONNECTED";
            label3.BackColor = Color.Red;
            _connection.Disconnect();
        }

        private void responseFormatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void sendFormatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void convertReqTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] result = _factory.Resolve((DataFormat)convertReqCb.SelectedItem).ConvertRequest(convertReqTextBox.Text, endianCheck.Checked, clrfCheckBox.Checked);
                convertResultTextBox.Text = _factory.Resolve((DataFormat)convertResultCb.SelectedItem).ConvertResponse(result, endianCheck.Checked);
            }
            catch { convertResultTextBox.Clear(); }
        }
        private void convertResultTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void resultView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            resultView.ScrollBars = ScrollBars.Both;
            if (e.Control is TextBox tb)
            {

                tb.ReadOnly = true;
                tb.ShortcutsEnabled = true;
                tb.ContextMenuStrip = contextMenuStrip1;

            }
        }
        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            if (_connection.IsConnected)
            {
                label3.Text = "CONNECTED";
                label3.BackColor = Color.Green;
            }
            else
            {
                label3.Text = "DISCONNECTED";
                label3.BackColor = Color.Red;
                _connection.Disconnect();
            }
        }
        private void endianCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            convertReqTextBox_TextChanged(convertReqTextBox, EventArgs.Empty);

        }

        private void convertReqCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void sendMessageBox_TextChanged(object sender, EventArgs e)
        {
        }

        private async void sendMessageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The message has been sent. Wait for {(int)timeoutMsUd.Value}ms to send another!");
            if (_connection == null) MessageBox.Show("Not connected to server.");

            cts = new CancellationTokenSource();
            var token = cts.Token;
            if (sendMessageBox.Text == string.Empty || sendMessageBox.Text == null) { MessageBox.Show("Enter a message to send."); return; }
            try
            {

                if (!loopCheck.Checked)
                {
                    var result = await _messageService.SendAndReceiveAsync(sendMessageBox.Text,
                        (DataFormat)sendFormatCb.SelectedIndex,
                        (DataFormat)responseFormatCb.SelectedIndex,
                        endianCheck.Checked,
                        clrfCheckBox.Checked,
                        (int)timeoutMsUd.Value,
                        token);

                    resultView.Rows.Add(sendMessageBox.Text, result.HexDump, result.Formatted);
                    return;
                }
                if (loopRunning)
                {
                    MessageBox.Show("Cancel the active loop");
                    return;
                }
                loopRunning = true;
                try
                {
                    while (!token.IsCancellationRequested)
                    {
                        if (token.IsCancellationRequested) break;
                        greenVisible = true;
                        colorTimer.Start();
                        loopColor.Invalidate();

                        var result = await _messageService.SendAndReceiveAsync(sendMessageBox.Text,
                            (DataFormat)sendFormatCb.SelectedIndex,
                            (DataFormat)responseFormatCb.SelectedIndex,
                            endianCheck.Checked,
                            clrfCheckBox.Checked,
                            (int)timeoutMsUd.Value,
                            token);

                        resultView.Rows.Add(sendMessageBox.Text, result.HexDump, result.Formatted);
                        await Task.Delay(1000, token);
                    }
                }
                finally { loopRunning = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void convertResultCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void resultView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)

        {
            resultView.ScrollBars = ScrollBars.Both;
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                resultView.ClearSelection();
                resultView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                contextMenuStrip1.Show(Cursor.Position);
            }
        }


        private void ConvertCellToFormat(DataFormat targetFormat)
        {
            string selectedText = null;

            if (resultView.EditingControl is TextBox tb && !string.IsNullOrEmpty(tb.SelectedText)) { selectedText = tb.SelectedText; }

            if (string.IsNullOrEmpty(selectedText) && resultView.SelectedCells.Count != 0)
            {
                selectedText = resultView.SelectedCells[0].Value?.ToString();
            }
            if (string.IsNullOrEmpty(selectedText)) return;
            try
            {
                var cell = resultView.SelectedCells[0];
                var col = cell.OwningColumn.Name;
                byte[] formatedMessage = null;

                if (col == "Response")
                {
                    formatedMessage = _factory.Resolve(DataFormat.Hex).ConvertRequest(selectedText, endianCheck.Checked, clrfCheckBox.Checked);
                    convertReqCb.SelectedItem = DataFormat.Hex;

                }
                else if (col == "Formated")
                {
                    formatedMessage = _factory.Resolve((DataFormat)responseFormatCb.SelectedIndex).ConvertRequest(selectedText, endianCheck.Checked, clrfCheckBox.Checked);
                    convertReqCb.SelectedItem = responseFormatCb.SelectedItem;

                }
                else
                { MessageBox.Show("Select response or formated colums cell"); }
                string result = _factory.Resolve(targetFormat).ConvertResponse(formatedMessage, endianCheck.Checked);

                convertResultTextBox.Clear();
                convertReqTextBox.Clear();
                convertReqTextBox.Text = selectedText;
                convertResultTextBox.Text = result;
                convertResultCb.SelectedItem = targetFormat;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }
        private void toHexStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Hex);

        }
        private void toDecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Decimal);

        }

        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Binary);

        }

        private void toUtf8StringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Utf8String);

        }

        private void toASCIIStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.ASCIIString);

        }

        private void toFloatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Float);

        }

        private void toDoubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Double);

        }

        private void toInt16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Int16);

        }

        private void toInt32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Int32);

        }

        private void toUInt16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.UInt16);


        }

        private void toUInt32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.UInt32);

        }

        private void toInt64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.Int64);

        }

        private void toUInt64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertCellToFormat(DataFormat.UInt64);

        }

        private void copyTheCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultView.CurrentCell != null)
            {
                string result = resultView.CurrentCell.Value.ToString();
                if (!string.IsNullOrEmpty(result))
                { Clipboard.SetText(result); }
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}


