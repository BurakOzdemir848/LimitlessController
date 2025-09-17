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
            components = new System.ComponentModel.Container();
            ColumnHeader KEYS;
            send = new Button();
            resultView = new DataGridView();
            ipPortPanel = new Panel();
            disconnectButton = new Button();
            label3 = new Label();
            connectIp = new Button();
            portBox = new TextBox();
            ipBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            loopCheck = new CheckBox();
            allSelect = new CheckBox();
            button2 = new Button();
            loopColor = new Panel();
            colorTimer = new System.Windows.Forms.Timer(components);
            keyAddButton = new Button();
            keyDeleteButton = new Button();
            keyTextBox = new TextBox();
            keyList = new ListView();
            clrfCheckBox = new CheckBox();
            sendFormatCb = new ComboBox();
            responseFormatCb = new ComboBox();
            Key = new DataGridViewTextBoxColumn();
            Response = new DataGridViewTextBoxColumn();
            Formated = new DataGridViewTextBoxColumn();
            KEYS = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)resultView).BeginInit();
            ipPortPanel.SuspendLayout();
            SuspendLayout();
            // 
            // KEYS
            // 
            KEYS.Text = "KEYS";
            KEYS.Width = 300;
            // 
            // send
            // 
            send.BackColor = Color.Lime;
            send.Location = new Point(315, 224);
            send.Name = "send";
            send.Size = new Size(101, 47);
            send.TabIndex = 2;
            send.Text = "Send Keys";
            send.UseVisualStyleBackColor = false;
            send.Click += Send_Click;
            // 
            // resultView
            // 
            resultView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultView.Columns.AddRange(new DataGridViewColumn[] { Key, Response, Formated });
            resultView.Location = new Point(952, 12);
            resultView.Name = "resultView";
            resultView.RowHeadersWidth = 62;
            resultView.Size = new Size(916, 1000);
            resultView.TabIndex = 0;
            resultView.CellContentClick += resultView_CellContentClick;
            // 
            // ipPortPanel
            // 
            ipPortPanel.BackColor = SystemColors.ActiveBorder;
            ipPortPanel.Controls.Add(disconnectButton);
            ipPortPanel.Controls.Add(label3);
            ipPortPanel.Controls.Add(connectIp);
            ipPortPanel.Controls.Add(portBox);
            ipPortPanel.Controls.Add(ipBox);
            ipPortPanel.Controls.Add(label2);
            ipPortPanel.Controls.Add(label1);
            ipPortPanel.Location = new Point(42, 519);
            ipPortPanel.Name = "ipPortPanel";
            ipPortPanel.Size = new Size(375, 232);
            ipPortPanel.TabIndex = 11;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = Color.Red;
            disconnectButton.Location = new Point(203, 172);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(118, 37);
            disconnectButton.TabIndex = 14;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = false;
            disconnectButton.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point(118, 15);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 13;
            label3.Text = "DISCONNECTED";
            label3.Click += label3_Click;
            // 
            // connectIp
            // 
            connectIp.BackColor = Color.Lime;
            connectIp.Location = new Point(60, 172);
            connectIp.Name = "connectIp";
            connectIp.Size = new Size(118, 37);
            connectIp.TabIndex = 13;
            connectIp.Text = "Connect";
            connectIp.UseVisualStyleBackColor = false;
            connectIp.Click += button2_Click;
            // 
            // portBox
            // 
            portBox.Location = new Point(110, 108);
            portBox.Name = "portBox";
            portBox.Size = new Size(150, 31);
            portBox.TabIndex = 13;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(110, 65);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(150, 31);
            ipBox.TabIndex = 12;
            ipBox.TextChanged += ipBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 68);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(845, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 12;
            button1.Text = "Stop Loop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loopCheck
            // 
            loopCheck.AutoSize = true;
            loopCheck.BackColor = Color.LightSteelBlue;
            loopCheck.Location = new Point(333, 150);
            loopCheck.Name = "loopCheck";
            loopCheck.Size = new Size(84, 29);
            loopCheck.TabIndex = 13;
            loopCheck.Text = "Loop ";
            loopCheck.UseVisualStyleBackColor = false;
            loopCheck.CheckedChanged += loopCheck_CheckedChanged;
            // 
            // allSelect
            // 
            allSelect.AutoSize = true;
            allSelect.BackColor = Color.LightSteelBlue;
            allSelect.Location = new Point(315, 80);
            allSelect.Name = "allSelect";
            allSelect.Size = new Size(102, 29);
            allSelect.TabIndex = 14;
            allSelect.Text = "selectAll";
            allSelect.UseVisualStyleBackColor = false;
            allSelect.CheckedChanged += allSelect_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(1771, 12);
            button2.Name = "button2";
            button2.Size = new Size(97, 38);
            button2.TabIndex = 15;
            button2.Text = "ClearLogs";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // loopColor
            // 
            loopColor.BackColor = Color.Red;
            loopColor.Location = new Point(952, 12);
            loopColor.Name = "loopColor";
            loopColor.Size = new Size(18, 17);
            loopColor.TabIndex = 16;
            loopColor.Paint += loopColor_Paint;
            // 
            // colorTimer
            // 
            colorTimer.Tick += colorTimer_Tick;
            // 
            // keyAddButton
            // 
            keyAddButton.BackColor = Color.DarkSeaGreen;
            keyAddButton.Location = new Point(188, 35);
            keyAddButton.Name = "keyAddButton";
            keyAddButton.Size = new Size(60, 34);
            keyAddButton.TabIndex = 18;
            keyAddButton.Text = "Add";
            keyAddButton.UseVisualStyleBackColor = false;
            keyAddButton.Click += keyAddButton_Click;
            // 
            // keyDeleteButton
            // 
            keyDeleteButton.BackColor = Color.RosyBrown;
            keyDeleteButton.Location = new Point(254, 34);
            keyDeleteButton.Name = "keyDeleteButton";
            keyDeleteButton.Size = new Size(163, 37);
            keyDeleteButton.TabIndex = 19;
            keyDeleteButton.Text = "Delete Selected";
            keyDeleteButton.UseVisualStyleBackColor = false;
            keyDeleteButton.Click += keyDeleteButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(32, 35);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(150, 31);
            keyTextBox.TabIndex = 20;
            keyTextBox.TextChanged += textBox1_TextChanged;
            // 
            // keyList
            // 
            keyList.CheckBoxes = true;
            keyList.Columns.AddRange(new ColumnHeader[] { KEYS });
            keyList.FullRowSelect = true;
            keyList.Location = new Point(33, 80);
            keyList.Name = "keyList";
            keyList.Size = new Size(384, 420);
            keyList.TabIndex = 21;
            keyList.UseCompatibleStateImageBehavior = false;
            keyList.View = View.Details;
            keyList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clrfCheckBox
            // 
            clrfCheckBox.AutoSize = true;
            clrfCheckBox.BackColor = Color.LightSteelBlue;
            clrfCheckBox.Location = new Point(300, 115);
            clrfCheckBox.Name = "clrfCheckBox";
            clrfCheckBox.Size = new Size(117, 29);
            clrfCheckBox.TabIndex = 22;
            clrfCheckBox.Text = "CLRF(\\r\\n)";
            clrfCheckBox.UseVisualStyleBackColor = false;
            clrfCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // sendFormatCb
            // 
            sendFormatCb.FormattingEnabled = true;
            sendFormatCb.Location = new Point(248, 185);
            sendFormatCb.Name = "sendFormatCb";
            sendFormatCb.Size = new Size(169, 33);
            sendFormatCb.TabIndex = 23;
            sendFormatCb.Text = "Message Format";
            // 
            // responseFormatCb
            // 
            responseFormatCb.FormattingEnabled = true;
            responseFormatCb.Location = new Point(770, 56);
            responseFormatCb.Name = "responseFormatCb";
            responseFormatCb.Size = new Size(175, 33);
            responseFormatCb.TabIndex = 24;
            responseFormatCb.Text = "Response Format";
            responseFormatCb.SelectedIndexChanged += responseFormatCb_SelectedIndexChanged;
            responseFormatCb.DataSource=Enum.GetValues(typeof(DataFormat));
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.MinimumWidth = 35;
            Key.Name = "Key";
            Key.Width = 50;
            // 
            // Response
            // 
            Response.HeaderText = "Response";
            Response.MinimumWidth = 8;
            Response.Name = "Response";
            Response.Width = 400;
            // 
            // Formated
            // 
            Formated.HeaderText = "Formated";
            Formated.MinimumWidth = 8;
            Formated.Name = "Formated";
            Formated.Width = 400;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1898, 1024);
            Controls.Add(responseFormatCb);
            Controls.Add(sendFormatCb);
            Controls.Add(clrfCheckBox);
            Controls.Add(keyTextBox);
            Controls.Add(keyDeleteButton);
            Controls.Add(keyAddButton);
            Controls.Add(loopColor);
            Controls.Add(button2);
            Controls.Add(allSelect);
            Controls.Add(loopCheck);
            Controls.Add(button1);
            Controls.Add(send);
            Controls.Add(resultView);
            Controls.Add(ipPortPanel);
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
        private Panel ipPortPanel;
        private TextBox portBox;
        private TextBox ipBox;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button connectIp;
        private Label label3;
        private CheckBox loopCheck;
        private CheckBox allSelect;
        private Button button2;
        private Panel loopColor;
        private System.Windows.Forms.Timer colorTimer;
        private Button keyAddButton;
        private Button keyDeleteButton;
        private TextBox keyTextBox;
        private ListView keyList;
        private Button disconnectButton;
        private CheckBox clrfCheckBox;
        private ComboBox sendFormatCb;
        private ComboBox responseFormatCb;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Response;
        private DataGridViewTextBoxColumn Formated;
    }
}
