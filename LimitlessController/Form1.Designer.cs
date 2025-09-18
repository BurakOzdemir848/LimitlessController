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
            Key = new DataGridViewTextBoxColumn();
            Response = new DataGridViewTextBoxColumn();
            Formated = new DataGridViewTextBoxColumn();
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
            clearLogBtn = new Button();
            loopColor = new Panel();
            colorTimer = new System.Windows.Forms.Timer(components);
            keyAddButton = new Button();
            keyDeleteButton = new Button();
            keyTextBox = new TextBox();
            keyList = new ListView();
            clrfCheckBox = new CheckBox();
            sendFormatCb = new ComboBox();
            responseFormatCb = new ComboBox();
            convertReqTextBox = new RichTextBox();
            convertResultTextBox = new RichTextBox();
            convertResultCb = new ComboBox();
            convertReqCb = new ComboBox();
            ConnectionTimer = new System.Windows.Forms.Timer(components);
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
            send.Location = new Point(423, 35);
            send.Name = "send";
            send.Size = new Size(101, 39);
            send.TabIndex = 2;
            send.Text = "Send Keys";
            send.UseVisualStyleBackColor = false;
            send.Click += Send_Click;
            // 
            // resultView
            // 
            resultView.AllowUserToAddRows = false;
            resultView.AllowUserToDeleteRows = false;
            resultView.BackgroundColor = Color.DarkSeaGreen;
            resultView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultView.Columns.AddRange(new DataGridViewColumn[] { Key, Response, Formated });
            resultView.Location = new Point(952, 12);
            resultView.Name = "resultView";
            resultView.RowHeadersWidth = 62;
            resultView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultView.Size = new Size(916, 1000);
            resultView.TabIndex = 0;
            resultView.CellContentClick += resultView_CellContentClick;
            resultView.EditingControlShowing += resultView_EditingControlShowing;
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
            ipPortPanel.Location = new Point(499, 211);
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
            connectIp.Click += ConnectBtn_Click;
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
            ipBox.Location = new Point(110, 71);
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
            button1.Location = new Point(845, 34);
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
            loopCheck.Location = new Point(423, 119);
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
            allSelect.Location = new Point(33, 12);
            allSelect.Name = "allSelect";
            allSelect.Size = new Size(102, 29);
            allSelect.TabIndex = 14;
            allSelect.Text = "selectAll";
            allSelect.UseVisualStyleBackColor = false;
            allSelect.CheckedChanged += allSelect_CheckedChanged;
            // 
            // clearLogBtn
            // 
            clearLogBtn.BackColor = Color.Red;
            clearLogBtn.Location = new Point(1771, 12);
            clearLogBtn.Name = "clearLogBtn";
            clearLogBtn.Size = new Size(97, 38);
            clearLogBtn.TabIndex = 15;
            clearLogBtn.Text = "ClearLogs";
            clearLogBtn.UseVisualStyleBackColor = false;
            clearLogBtn.Click += clearLogBtn_Click_1;
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
            keyAddButton.Location = new Point(189, 466);
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
            keyDeleteButton.Location = new Point(254, 463);
            keyDeleteButton.Name = "keyDeleteButton";
            keyDeleteButton.Size = new Size(163, 37);
            keyDeleteButton.TabIndex = 19;
            keyDeleteButton.Text = "Delete Selected";
            keyDeleteButton.UseVisualStyleBackColor = false;
            keyDeleteButton.Click += keyDeleteButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(33, 466);
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
            keyList.Location = new Point(33, 37);
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
            clrfCheckBox.Location = new Point(141, 12);
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
            sendFormatCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            sendFormatCb.Location = new Point(423, 80);
            sendFormatCb.Name = "sendFormatCb";
            sendFormatCb.Size = new Size(169, 33);
            sendFormatCb.TabIndex = 23;
            sendFormatCb.SelectedIndexChanged += sendFormatCb_SelectedIndexChanged;
            sendFormatCb.SelectedIndex = 4;
            // 
            // responseFormatCb
            // 
           
            responseFormatCb.FormattingEnabled = true;
            responseFormatCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            responseFormatCb.Location = new Point(771, 80);
            responseFormatCb.Name = "responseFormatCb";
            responseFormatCb.Size = new Size(175, 33);
            responseFormatCb.TabIndex = 24;
            responseFormatCb.SelectedIndexChanged += responseFormatCb_SelectedIndexChanged;
            responseFormatCb.SelectedIndex = 2;
            // 
            // convertReqTextBox
            // 
            convertReqTextBox.Location = new Point(319, 723);
            convertReqTextBox.Name = "convertReqTextBox";
            convertReqTextBox.Size = new Size(253, 144);
            convertReqTextBox.TabIndex = 26;
            convertReqTextBox.Text = "";
            convertReqTextBox.TextChanged += convertReqTextBox_TextChanged;
            // 
            // convertResultTextBox
            // 
            convertResultTextBox.Location = new Point(693, 723);
            convertResultTextBox.Name = "convertResultTextBox";
            convertResultTextBox.Size = new Size(253, 144);
            convertResultTextBox.TabIndex = 27;
            convertResultTextBox.Text = "";
            convertResultTextBox.TextChanged += convertResultTextBox_TextChanged;
            // 
            // convertResultCb
            // 
            
            convertResultCb.FormattingEnabled = true;
            convertResultCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            convertResultCb.Location = new Point(698, 684);
            convertResultCb.Name = "convertResultCb";
            convertResultCb.Size = new Size(145, 33);
            convertResultCb.TabIndex = 28;
            convertResultCb.SelectedIndexChanged += convertCb_SelectedIndexChanged;
            convertResultCb.SelectedIndex = 2;
            // 
            // convertReqCb
            // 
           
            convertReqCb.FormattingEnabled = true;
            convertReqCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            convertReqCb.Location = new Point(423, 684);
            convertReqCb.Name = "convertReqCb";
            convertReqCb.Size = new Size(145, 33);
            convertReqCb.TabIndex = 29;
            convertReqCb.SelectedIndex = 1;
            // 
            // Connection
            // 
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1898, 1024);
            Controls.Add(convertReqCb);
            Controls.Add(convertResultCb);
            Controls.Add(convertResultTextBox);
            Controls.Add(convertReqTextBox);
            Controls.Add(responseFormatCb);
            Controls.Add(sendFormatCb);
            Controls.Add(clrfCheckBox);
            Controls.Add(keyTextBox);
            Controls.Add(keyDeleteButton);
            Controls.Add(keyAddButton);
            Controls.Add(loopColor);
            Controls.Add(clearLogBtn);
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
        private Button clearLogBtn;
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
        private RichTextBox convertReqTextBox;
        private RichTextBox convertResultTextBox;
        private ComboBox convertResultCb;
        private ComboBox convertReqCb;
        private System.Windows.Forms.Timer ConnectionTimer;
    }
}
