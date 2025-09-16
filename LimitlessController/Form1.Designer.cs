namespace LimitlessController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            send = new Button();
            resultView = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Response = new DataGridViewTextBoxColumn();
            selectAll = new RadioButton();
            ipPortPanel = new Panel();
            connectIp = new Button();
            portBox = new TextBox();
            ipBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            keyList = new CheckedListBox();
            button1 = new Button();
            loop = new RadioButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultView).BeginInit();
            ipPortPanel.SuspendLayout();
            SuspendLayout();
            // 
            // send
            // 
            send.BackColor = Color.Lime;
            send.Location = new Point(630, 263);
            send.Name = "send";
            send.Size = new Size(125, 39);
            send.TabIndex = 2;
            send.Text = "Send Keys";
            send.UseVisualStyleBackColor = false;
            send.Click += Save_Click;
            // 
            // resultView
            // 
            resultView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultView.Columns.AddRange(new DataGridViewColumn[] { Key, Response });
            resultView.Location = new Point(811, 66);
            resultView.Name = "resultView";
            resultView.RowHeadersWidth = 62;
            resultView.Size = new Size(364, 337);
            resultView.TabIndex = 0;
            resultView.CellContentClick += resultView_CellContentClick;
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.MinimumWidth = 8;
            Key.Name = "Key";
            Key.Width = 150;
            // 
            // Response
            // 
            Response.HeaderText = "Response";
            Response.MinimumWidth = 8;
            Response.Name = "Response";
            Response.Width = 150;
            // 
            // selectAll
            // 
            selectAll.AutoSize = true;
            selectAll.Location = new Point(46, 28);
            selectAll.Name = "selectAll";
            selectAll.Size = new Size(108, 29);
            selectAll.TabIndex = 9;
            selectAll.TabStop = true;
            selectAll.Text = "Select All";
            selectAll.UseVisualStyleBackColor = true;
            selectAll.CheckedChanged += selectAll_CheckedChanged;
            // 
            // ipPortPanel
            // 
            ipPortPanel.BackColor = SystemColors.ActiveBorder;
            ipPortPanel.Controls.Add(label3);
            ipPortPanel.Controls.Add(connectIp);
            ipPortPanel.Controls.Add(portBox);
            ipPortPanel.Controls.Add(ipBox);
            ipPortPanel.Controls.Add(label2);
            ipPortPanel.Controls.Add(label1);
            ipPortPanel.Location = new Point(283, 223);
            ipPortPanel.Name = "ipPortPanel";
            ipPortPanel.Size = new Size(300, 180);
            ipPortPanel.TabIndex = 11;
            // 
            // connectIp
            // 
            connectIp.Location = new Point(127, 132);
            connectIp.Name = "connectIp";
            connectIp.Size = new Size(112, 34);
            connectIp.TabIndex = 13;
            connectIp.Text = "Connect";
            connectIp.UseVisualStyleBackColor = true;
            connectIp.Click += button2_Click;
            // 
            // portBox
            // 
            portBox.Location = new Point(110, 95);
            portBox.Name = "portBox";
            portBox.Size = new Size(150, 31);
            portBox.TabIndex = 13;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(110, 47);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(150, 31);
            ipBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // keyList
            // 
            keyList.BackColor = SystemColors.ActiveBorder;
            keyList.FormattingEnabled = true;
            keyList.Items.AddRange(new object[] { "sspaValue", "sspaAt", "modemTx", "modemSr", "modemLevel", "modemFreq", "acuStep", "acuRef", "acuPol", "acuGuc", "acuEl", "acuAz" });
            keyList.Location = new Point(46, 63);
            keyList.Name = "keyList";
            keyList.Size = new Size(169, 340);
            keyList.TabIndex = 1;
            keyList.Tag = "";
            keyList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(630, 308);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 12;
            button1.Text = "Stop Loop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loop
            // 
            loop.AutoSize = true;
            loop.Location = new Point(642, 223);
            loop.Name = "loop";
            loop.Size = new Size(83, 29);
            loop.TabIndex = 3;
            loop.TabStop = true;
            loop.Text = "Loop ";
            loop.UseVisualStyleBackColor = true;
            loop.CheckedChanged += loopButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point(71, 4);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 13;
            label3.Text = "DISCONNECTED";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1272, 755);
            Controls.Add(loop);
            Controls.Add(button1);
            Controls.Add(resultView);
            Controls.Add(ipPortPanel);
            Controls.Add(selectAll);
            Controls.Add(send);
            Controls.Add(keyList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)resultView).EndInit();
            ipPortPanel.ResumeLayout(false);
            ipPortPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button send;
        private DataGridView resultView;
        private RadioButton selectAll;
        private Panel ipPortPanel;
        private TextBox portBox;
        private TextBox ipBox;
        private Label label2;
        private Label label1;
        private CheckedListBox keyList;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Response;
        private Button button1;
        private RadioButton loop;
        private Button connectIp;
        private Label label3;
    }
}
