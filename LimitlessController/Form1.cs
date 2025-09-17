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
                            byte[] response = await connection.SendAsync(clrfCheckBox.Checked, item.Text);

                            string hexDump = BitConverter.ToString(response);
                            int rowIndex = resultView.Rows.Add(item.Text, hexDump, "");
                            resultView.Rows[rowIndex].Tag = response;
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

                                byte[] response = await connection.SendAsync(clrfCheckBox.Checked, item.Text);
                                resultView.Rows.Add(item.Text, response);
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
            resultView.AllowUserToAddRows = false;
            resultView.ReadOnly = true;
            resultView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resultView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            resultView.Columns.Clear();
            resultView.Columns.Add("Key", "Key");
            resultView.Columns.Add("Response", "Response");
        }

        private void button1_Click(object sender, EventArgs e) //stop loop btn
        {
            cts?.Cancel();
            loopRunning = false;
            colorTimer.Stop();
            loopColor.Invalidate();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string ip = ipBox.Text;
            int port = int.Parse(portBox.Text);
            if (await connection.ConnectAsync(ip, port))
            {
                label3.Text = "CONNECTED";
                label3.BackColor = Color.Green;

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

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void button2_Click_1(object sender, EventArgs e)
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

            if (!string.IsNullOrEmpty(keyTextBox.Text) && !keyList.Items.ToString().Contains(keyTextBox.Text))
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
            DataFormat selected = (DataFormat)responseFormatCb.SelectedItem;

            foreach(DataGridViewRow row in resultView.Rows)
            {
                if (row.Tag is byte[] data)
                {
                    string formatted = DataConverter.ConvertResponse(data, selected);
                    row.Cells["Formated"].Value = formatted;
                }
            }   

        }
    }
}

