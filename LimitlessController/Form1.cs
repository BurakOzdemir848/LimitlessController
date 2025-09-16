using System.Net.Sockets;

namespace LimitlessController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectAll.Checked)
            {
                for (int i = 0; i < keyList.Items.Count; i++)
                {
                    keyList.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < keyList.Items.Count; i++)
                {
                    keyList.SetItemChecked(i, false);
                }
            }
        }

        private void loopButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void Save_Click(object sender, EventArgs e)
        {
            string ip = ipBox.Text;
            int port = int.Parse(portBox.Text);
            try
            {
                using (TcpClient client = new TcpClient(ip, port))
                using (NetworkStream stream = client.GetStream())
                {
                    if (!loop.Checked)
                    {
                        foreach (var item in keyList.CheckedItems)
                        {
                            string message = item.ToString();
                            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                            stream.Write(data, 0, data.Length);

                            byte[] responseData = new byte[256];
                            int bytes = stream.Read(responseData, 0, responseData.Length);
                            string response = System.Text.Encoding.ASCII.GetString(responseData, 0, bytes);
                            resultView.Rows.Add(message, response);
                        }
                    }
                    else if (loop.Checked)
                    {
                        CancellationTokenSource cts = new CancellationTokenSource();

                        while (!cts.IsCancellationRequested)
                        {
                            foreach (var item in keyList.CheckedItems)
                            {
                                if (cts.IsCancellationRequested)
                                    break;
                                string message = item.ToString();
                                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream.Write(data, 0, data.Length);
                                byte[] responseData = new byte[256];
                                int bytes = stream.Read(responseData, 0, responseData.Length);
                                string response = System.Text.Encoding.ASCII.GetString(responseData, 0, bytes);
                                resultView.Invoke(new Action(() => resultView.Rows.Add(message, response)));
                                await Task.Delay(1000);
                            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.Cancel();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ip = ipBox.Text;
            int port = int.Parse(portBox.Text);
            try
            {
                using (TcpClient client = new TcpClient(ip, port))
                {
                    label3.Text = "Connected";
                    label3.ForeColor = Color.Green;
                }
            }
            catch
            {
                label3.Text = "Disconnected";
                label3.ForeColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

