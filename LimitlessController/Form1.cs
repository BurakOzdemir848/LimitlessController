using System.Net.Sockets;
using System.Text.Json;

namespace LimitlessController
{
    public partial class Form1 : Form
    {
        ConnectionManager connection = new ConnectionManager();

        CancellationTokenSource cts = new CancellationTokenSource();
        bool greenVisible;
        bool loopRunning;

        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Config.txt yok");
            }
        }


        private async void Send_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                if (connection == null) MessageBox.Show("Not connected to server.");
                {
                    if (!loopCheck.Checked)
                    {
                        foreach (ListViewItem item in keyList.CheckedItems)
                        {
                            
                            byte[] formatedMessage = DataConverter.ConvertRequest(item.Text, (DataFormat)sendFormatCb.SelectedIndex);

                            byte[] response = await connection.SendAsync(clrfCheckBox.Checked, formatedMessage);

                            string hexDump = BitConverter.ToString(response);
                            string Formated = DataConverter.ConvertResponse(response, (DataFormat)responseFormatCb.SelectedIndex);
                            resultView.Rows.Add(item.Text, hexDump, Formated);

                        }
                    }
                    else if (loopCheck.Checked)
                    {
                        while (!token.IsCancellationRequested)
                            foreach (ListViewItem item in keyList.CheckedItems)
                            {
                                if (token.IsCancellationRequested) break;

                                loopRunning = true;
                                greenVisible = true;
                                colorTimer.Start();
                                loopColor.Invalidate();

                                byte[] formatedMessage = DataConverter.ConvertRequest(item.Text, (DataFormat)sendFormatCb.SelectedIndex);
                                byte[] response = await connection.SendAsync(clrfCheckBox.Checked, formatedMessage);

                                string hexDump = BitConverter.ToString(response);
                                string Formated = DataConverter.ConvertResponse(response, (DataFormat)responseFormatCb.SelectedIndex);
                                resultView.Rows.Add(item.Text, hexDump, Formated);
                                await Task.Delay(1000, token);
                                
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void resultView_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            resultView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            resultView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            resultView.AllowUserToAddRows = false;
            resultView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (await connection.ConnectAsync(ip, port))
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
        }//connect

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadFromTxt();
            ConnectionTimer.Interval = 1000;
            ConnectionTimer.Tick += ConnectionTimer_Tick;

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

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Disconnect();
            label3.Text = "DISCONNECTED";
            label3.BackColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
                byte[] result = DataConverter.ConvertRequest(convertReqTextBox.Text, (DataFormat)convertReqCb.SelectedItem);
                convertResultTextBox.Text = DataConverter.ConvertResponse(result, (DataFormat)convertResultCb.SelectedItem);
            }
            catch { convertResultTextBox.Clear(); }
        }

        private void convertResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.ReadOnly = true;
                tb.ShortcutsEnabled = true;
            }
        }
  



        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {

            if (connection.IsConnected) {
                label3.Text = "CONNECTED";
                label3.BackColor = Color.Green;

            }
            else
            {
                label3.Text = "DISCONNECTED";
                label3.BackColor = Color.Red;
            }



        }
    }
}

