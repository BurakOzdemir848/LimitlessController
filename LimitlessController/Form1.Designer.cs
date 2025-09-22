using LimitlessController.Core.Models;

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
            contextMenuStrip1 = new ContextMenuStrip(components);
            convertToolStripMenuItem = new ToolStripMenuItem();
            toHexToolStripMenuItem = new ToolStripMenuItem();
            toToolStripMenuItem1 = new ToolStripMenuItem();
            toToolStripMenuItem = new ToolStripMenuItem();
            toUtf8StringToolStripMenuItem = new ToolStripMenuItem();
            toASCIIStringToolStripMenuItem = new ToolStripMenuItem();
            toFloatToolStripMenuItem = new ToolStripMenuItem();
            toDoubleToolStripMenuItem = new ToolStripMenuItem();
            toInt16ToolStripMenuItem = new ToolStripMenuItem();
            toInt32ToolStripMenuItem = new ToolStripMenuItem();
            toUInt16ToolStripMenuItem = new ToolStripMenuItem();
            toUInt32ToolStripMenuItem = new ToolStripMenuItem();
            toInt64ToolStripMenuItem = new ToolStripMenuItem();
            toUInt64ToolStripMenuItem = new ToolStripMenuItem();
            copyTheCellToolStripMenuItem = new ToolStripMenuItem();
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
            endianCheck = new CheckBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label13 = new Label();
            panel5 = new Panel();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            sendMessageBox = new TextBox();
            label4 = new Label();
            label10 = new Label();
            sendMessageBtn = new Button();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label14 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            KEYS = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)resultView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ipPortPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // KEYS
            // 
            KEYS.Text = "KEYS";
            KEYS.Width = 300;
            // 
            // send
            // 
            send.BackColor = SystemColors.ActiveCaption;
            send.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            send.ForeColor = SystemColors.ActiveCaptionText;
            send.Location = new Point(52, 259);
            send.Margin = new Padding(2, 2, 2, 2);
            send.Name = "send";
            send.Size = new Size(79, 35);
            send.TabIndex = 35;
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
            resultView.ContextMenuStrip = contextMenuStrip1;
            resultView.Location = new Point(494, -1);
            resultView.Margin = new Padding(2, 2, 2, 2);
            resultView.Name = "resultView";
            resultView.RowHeadersWidth = 62;
            resultView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultView.Size = new Size(833, 440);
            resultView.TabIndex = 0;
            resultView.CellContentClick += resultView_CellContentClick;
            resultView.CellMouseDown += resultView_CellMouseDown;
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
            Formated.Width = 675;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { convertToolStripMenuItem, copyTheCellToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // convertToolStripMenuItem
            // 
            convertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toHexToolStripMenuItem, toToolStripMenuItem1, toToolStripMenuItem, toUtf8StringToolStripMenuItem, toASCIIStringToolStripMenuItem, toFloatToolStripMenuItem, toDoubleToolStripMenuItem, toInt16ToolStripMenuItem, toInt32ToolStripMenuItem, toUInt16ToolStripMenuItem, toUInt32ToolStripMenuItem, toInt64ToolStripMenuItem, toUInt64ToolStripMenuItem });
            convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            convertToolStripMenuItem.Size = new Size(145, 22);
            convertToolStripMenuItem.Text = "Convert";
            // 
            // toHexToolStripMenuItem
            // 
            toHexToolStripMenuItem.Name = "toHexToolStripMenuItem";
            toHexToolStripMenuItem.Size = new Size(147, 22);
            toHexToolStripMenuItem.Text = "to Decimal";
            toHexToolStripMenuItem.Click += toDecimalToolStripMenuItem_Click;
            // 
            // toToolStripMenuItem1
            // 
            toToolStripMenuItem1.Name = "toToolStripMenuItem1";
            toToolStripMenuItem1.Size = new Size(147, 22);
            toToolStripMenuItem1.Text = "to Hex";
            toToolStripMenuItem1.Click += toHexStripMenuItem1_Click;
            // 
            // toToolStripMenuItem
            // 
            toToolStripMenuItem.Name = "toToolStripMenuItem";
            toToolStripMenuItem.Size = new Size(147, 22);
            toToolStripMenuItem.Text = "to Binary";
            // 
            // toUtf8StringToolStripMenuItem
            // 
            toUtf8StringToolStripMenuItem.Name = "toUtf8StringToolStripMenuItem";
            toUtf8StringToolStripMenuItem.Size = new Size(147, 22);
            toUtf8StringToolStripMenuItem.Text = "to Utf8String";
            // 
            // toASCIIStringToolStripMenuItem
            // 
            toASCIIStringToolStripMenuItem.Name = "toASCIIStringToolStripMenuItem";
            toASCIIStringToolStripMenuItem.Size = new Size(147, 22);
            toASCIIStringToolStripMenuItem.Text = "to ASCIIString";
            // 
            // toFloatToolStripMenuItem
            // 
            toFloatToolStripMenuItem.Name = "toFloatToolStripMenuItem";
            toFloatToolStripMenuItem.Size = new Size(147, 22);
            toFloatToolStripMenuItem.Text = "to Float";
            // 
            // toDoubleToolStripMenuItem
            // 
            toDoubleToolStripMenuItem.Name = "toDoubleToolStripMenuItem";
            toDoubleToolStripMenuItem.Size = new Size(147, 22);
            toDoubleToolStripMenuItem.Text = "to Double";
            // 
            // toInt16ToolStripMenuItem
            // 
            toInt16ToolStripMenuItem.Name = "toInt16ToolStripMenuItem";
            toInt16ToolStripMenuItem.Size = new Size(147, 22);
            toInt16ToolStripMenuItem.Text = "to Int16";
            // 
            // toInt32ToolStripMenuItem
            // 
            toInt32ToolStripMenuItem.Name = "toInt32ToolStripMenuItem";
            toInt32ToolStripMenuItem.Size = new Size(147, 22);
            toInt32ToolStripMenuItem.Text = "to Int32";
            // 
            // toUInt16ToolStripMenuItem
            // 
            toUInt16ToolStripMenuItem.Name = "toUInt16ToolStripMenuItem";
            toUInt16ToolStripMenuItem.Size = new Size(147, 22);
            toUInt16ToolStripMenuItem.Text = "to UInt16";
            // 
            // toUInt32ToolStripMenuItem
            // 
            toUInt32ToolStripMenuItem.Name = "toUInt32ToolStripMenuItem";
            toUInt32ToolStripMenuItem.Size = new Size(147, 22);
            toUInt32ToolStripMenuItem.Text = "to UInt 32";
            // 
            // toInt64ToolStripMenuItem
            // 
            toInt64ToolStripMenuItem.Name = "toInt64ToolStripMenuItem";
            toInt64ToolStripMenuItem.Size = new Size(147, 22);
            toInt64ToolStripMenuItem.Text = "to Int64";
            // 
            // toUInt64ToolStripMenuItem
            // 
            toUInt64ToolStripMenuItem.Name = "toUInt64ToolStripMenuItem";
            toUInt64ToolStripMenuItem.Size = new Size(147, 22);
            toUInt64ToolStripMenuItem.Text = "to UInt64";
            // 
            // copyTheCellToolStripMenuItem
            // 
            copyTheCellToolStripMenuItem.Name = "copyTheCellToolStripMenuItem";
            copyTheCellToolStripMenuItem.Size = new Size(145, 22);
            copyTheCellToolStripMenuItem.Text = "Copy the Cell";
            // 
            // ipPortPanel
            // 
            ipPortPanel.BackColor = SystemColors.ActiveCaption;
            ipPortPanel.BorderStyle = BorderStyle.Fixed3D;
            ipPortPanel.Controls.Add(disconnectButton);
            ipPortPanel.Controls.Add(label3);
            ipPortPanel.Controls.Add(connectIp);
            ipPortPanel.Controls.Add(portBox);
            ipPortPanel.Controls.Add(ipBox);
            ipPortPanel.Controls.Add(label2);
            ipPortPanel.Controls.Add(label1);
            ipPortPanel.Location = new Point(999, 442);
            ipPortPanel.Margin = new Padding(2, 2, 2, 2);
            ipPortPanel.Name = "ipPortPanel";
            ipPortPanel.Size = new Size(330, 171);
            ipPortPanel.TabIndex = 11;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = Color.Red;
            disconnectButton.Location = new Point(181, 107);
            disconnectButton.Margin = new Padding(2, 2, 2, 2);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(81, 34);
            disconnectButton.TabIndex = 14;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = false;
            disconnectButton.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(105, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 13;
            label3.Text = "DISCONNECTED";
            label3.Click += label3_Click;
            // 
            // connectIp
            // 
            connectIp.BackColor = Color.SteelBlue;
            connectIp.Location = new Point(88, 107);
            connectIp.Margin = new Padding(2, 2, 2, 2);
            connectIp.Name = "connectIp";
            connectIp.Size = new Size(80, 34);
            connectIp.TabIndex = 13;
            connectIp.Text = "Connect";
            connectIp.UseVisualStyleBackColor = false;
            connectIp.Click += ConnectBtn_Click;
            // 
            // portBox
            // 
            portBox.Location = new Point(131, 71);
            portBox.Margin = new Padding(2, 2, 2, 2);
            portBox.Name = "portBox";
            portBox.Size = new Size(106, 23);
            portBox.TabIndex = 13;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(131, 44);
            ipBox.Margin = new Padding(2, 2, 2, 2);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(106, 23);
            ipBox.TabIndex = 12;
            ipBox.TextChanged += ipBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "IP";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(207, 317);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 12;
            button1.Text = "Stop Loop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loopCheck
            // 
            loopCheck.AutoSize = true;
            loopCheck.BackColor = SystemColors.ActiveCaption;
            loopCheck.Location = new Point(11, 170);
            loopCheck.Margin = new Padding(2, 2, 2, 2);
            loopCheck.Name = "loopCheck";
            loopCheck.Size = new Size(56, 19);
            loopCheck.TabIndex = 13;
            loopCheck.Text = "Loop ";
            loopCheck.UseVisualStyleBackColor = false;
            loopCheck.CheckedChanged += loopCheck_CheckedChanged;
            // 
            // allSelect
            // 
            allSelect.AutoSize = true;
            allSelect.BackColor = SystemColors.ButtonFace;
            allSelect.Location = new Point(2, -1);
            allSelect.Margin = new Padding(2, 2, 2, 2);
            allSelect.Name = "allSelect";
            allSelect.Size = new Size(70, 19);
            allSelect.TabIndex = 14;
            allSelect.Text = "selectAll";
            allSelect.UseVisualStyleBackColor = false;
            allSelect.CheckedChanged += allSelect_CheckedChanged;
            // 
            // clearLogBtn
            // 
            clearLogBtn.BackColor = Color.Red;
            clearLogBtn.Location = new Point(494, 0);
            clearLogBtn.Margin = new Padding(2, 2, 2, 2);
            clearLogBtn.Name = "clearLogBtn";
            clearLogBtn.Size = new Size(78, 20);
            clearLogBtn.TabIndex = 15;
            clearLogBtn.Text = "ClearLogs";
            clearLogBtn.UseVisualStyleBackColor = false;
            clearLogBtn.Click += clearLogBtn_Click_1;
            // 
            // loopColor
            // 
            loopColor.BackColor = Color.Red;
            loopColor.Location = new Point(192, 336);
            loopColor.Margin = new Padding(2, 2, 2, 2);
            loopColor.Name = "loopColor";
            loopColor.Size = new Size(11, 10);
            loopColor.TabIndex = 16;
            loopColor.Paint += loopColor_Paint;
            // 
            // colorTimer
            // 
            colorTimer.Tick += colorTimer_Tick;
            // 
            // keyAddButton
            // 
            keyAddButton.BackColor = SystemColors.ActiveCaption;
            keyAddButton.Location = new Point(136, 80);
            keyAddButton.Margin = new Padding(2, 2, 2, 2);
            keyAddButton.Name = "keyAddButton";
            keyAddButton.Size = new Size(106, 27);
            keyAddButton.TabIndex = 18;
            keyAddButton.Text = "Add";
            keyAddButton.UseVisualStyleBackColor = false;
            keyAddButton.Click += keyAddButton_Click;
            // 
            // keyDeleteButton
            // 
            keyDeleteButton.BackColor = Color.Red;
            keyDeleteButton.Location = new Point(136, 23);
            keyDeleteButton.Margin = new Padding(2, 2, 2, 2);
            keyDeleteButton.Name = "keyDeleteButton";
            keyDeleteButton.Size = new Size(106, 27);
            keyDeleteButton.TabIndex = 19;
            keyDeleteButton.Text = "Delete Selected";
            keyDeleteButton.UseVisualStyleBackColor = false;
            keyDeleteButton.Click += keyDeleteButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(29, 84);
            keyTextBox.Margin = new Padding(2, 2, 2, 2);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(103, 23);
            keyTextBox.TabIndex = 20;
            keyTextBox.Text = "add a key..";
            keyTextBox.TextChanged += textBox1_TextChanged;
            // 
            // keyList
            // 
            keyList.BackColor = SystemColors.ControlDark;
            keyList.CheckBoxes = true;
            keyList.Columns.AddRange(new ColumnHeader[] { KEYS });
            keyList.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            keyList.FullRowSelect = true;
            keyList.Location = new Point(2, -1);
            keyList.Margin = new Padding(2, 2, 2, 2);
            keyList.Name = "keyList";
            keyList.Size = new Size(177, 615);
            keyList.TabIndex = 21;
            keyList.UseCompatibleStateImageBehavior = false;
            keyList.View = View.Details;
            keyList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clrfCheckBox
            // 
            clrfCheckBox.AutoSize = true;
            clrfCheckBox.BackColor = SystemColors.ActiveCaption;
            clrfCheckBox.Location = new Point(11, 147);
            clrfCheckBox.Margin = new Padding(2, 2, 2, 2);
            clrfCheckBox.Name = "clrfCheckBox";
            clrfCheckBox.Size = new Size(82, 19);
            clrfCheckBox.TabIndex = 22;
            clrfCheckBox.Text = "CLRF(\\r\\n)";
            clrfCheckBox.UseVisualStyleBackColor = false;
            // 
            // sendFormatCb
            // 
            sendFormatCb.DropDownStyle = ComboBoxStyle.DropDownList;
            sendFormatCb.FormattingEnabled = true;
            sendFormatCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            sendFormatCb.Location = new Point(10, 75);
            sendFormatCb.Margin = new Padding(2, 2, 2, 2);
            sendFormatCb.Name = "sendFormatCb";
            sendFormatCb.Size = new Size(122, 23);
            sendFormatCb.TabIndex = 23;
            sendFormatCb.SelectedIndexChanged += sendFormatCb_SelectedIndexChanged;
            // 
            // responseFormatCb
            // 
            responseFormatCb.DropDownStyle = ComboBoxStyle.DropDownList;
            responseFormatCb.FormattingEnabled = true;
            responseFormatCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            responseFormatCb.Location = new Point(143, 75);
            responseFormatCb.Margin = new Padding(2, 2, 2, 2);
            responseFormatCb.Name = "responseFormatCb";
            responseFormatCb.Size = new Size(122, 23);
            responseFormatCb.TabIndex = 24;
            responseFormatCb.SelectedIndexChanged += responseFormatCb_SelectedIndexChanged;
            // 
            // convertReqTextBox
            // 
            convertReqTextBox.Location = new Point(58, 47);
            convertReqTextBox.Margin = new Padding(2, 2, 2, 2);
            convertReqTextBox.Name = "convertReqTextBox";
            convertReqTextBox.Size = new Size(178, 113);
            convertReqTextBox.TabIndex = 26;
            convertReqTextBox.Text = "";
            convertReqTextBox.TextChanged += convertReqTextBox_TextChanged;
            // 
            // convertResultTextBox
            // 
            convertResultTextBox.BackColor = SystemColors.Window;
            convertResultTextBox.Location = new Point(271, 47);
            convertResultTextBox.Margin = new Padding(2, 2, 2, 2);
            convertResultTextBox.Name = "convertResultTextBox";
            convertResultTextBox.Size = new Size(164, 113);
            convertResultTextBox.TabIndex = 27;
            convertResultTextBox.Text = "";
            convertResultTextBox.TextChanged += convertResultTextBox_TextChanged;
            // 
            // convertResultCb
            // 
            convertResultCb.DropDownStyle = ComboBoxStyle.DropDownList;
            convertResultCb.FormattingEnabled = true;
            convertResultCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            convertResultCb.Location = new Point(271, 24);
            convertResultCb.Margin = new Padding(2, 2, 2, 2);
            convertResultCb.Name = "convertResultCb";
            convertResultCb.Size = new Size(112, 23);
            convertResultCb.TabIndex = 28;
            convertResultCb.SelectedIndexChanged += convertResultCb_SelectedIndexChanged;
            // 
            // convertReqCb
            // 
            convertReqCb.DropDownStyle = ComboBoxStyle.DropDownList;
            convertReqCb.FormattingEnabled = true;
            convertReqCb.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            convertReqCb.Location = new Point(129, 24);
            convertReqCb.Margin = new Padding(2, 2, 2, 2);
            convertReqCb.Name = "convertReqCb";
            convertReqCb.Size = new Size(108, 23);
            convertReqCb.TabIndex = 29;
            convertReqCb.SelectedIndexChanged += convertReqCb_SelectedIndexChanged;
            // 
            // ConnectionTimer
            // 
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            // 
            // endianCheck
            // 
            endianCheck.AutoSize = true;
            endianCheck.BackColor = SystemColors.ActiveCaption;
            endianCheck.Location = new Point(11, 119);
            endianCheck.Margin = new Padding(2, 2, 2, 2);
            endianCheck.Name = "endianCheck";
            endianCheck.Size = new Size(125, 19);
            endianCheck.TabIndex = 30;
            endianCheck.Text = "Device Big Endian?";
            endianCheck.UseVisualStyleBackColor = false;
            endianCheck.CheckedChanged += endianCheck_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(179, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 612);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ScrollBar;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label13);
            panel4.Controls.Add(send);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(loopColor);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(endianCheck);
            panel4.Controls.Add(loopCheck);
            panel4.Controls.Add(sendMessageBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(sendMessageBtn);
            panel4.Controls.Add(clrfCheckBox);
            panel4.Controls.Add(responseFormatCb);
            panel4.Controls.Add(sendFormatCb);
            panel4.Location = new Point(2, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 366);
            panel4.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(136, 213);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 43;
            label13.Text = "or ";
            label13.Click += label13_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 360);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 129);
            panel5.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(170, 213);
            label12.Name = "label12";
            label12.Size = new Size(113, 15);
            label12.TabIndex = 42;
            label12.Text = "Send one message:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 58);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 37;
            label7.Text = "Response format:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 18);
            label11.Name = "label11";
            label11.Size = new Size(130, 15);
            label11.TabIndex = 41;
            label11.Text = "Message Send Options:";
            // 
            // sendMessageBox
            // 
            sendMessageBox.Location = new Point(170, 232);
            sendMessageBox.Margin = new Padding(2, 2, 2, 2);
            sendMessageBox.Name = "sendMessageBox";
            sendMessageBox.ScrollBars = ScrollBars.Vertical;
            sendMessageBox.Size = new Size(122, 23);
            sendMessageBox.TabIndex = 34;
            sendMessageBox.Text = "message..";
            sendMessageBox.TextChanged += sendMessageBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 58);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 36;
            label4.Text = "Request format:";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(9, 215);
            label10.Name = "label10";
            label10.Size = new Size(121, 42);
            label10.TabIndex = 40;
            label10.Text = "Send checked keys from list:";
            // 
            // sendMessageBtn
            // 
            sendMessageBtn.BackColor = SystemColors.ActiveCaption;
            sendMessageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sendMessageBtn.ForeColor = SystemColors.ActiveCaptionText;
            sendMessageBtn.Location = new Point(213, 259);
            sendMessageBtn.Margin = new Padding(2, 2, 2, 2);
            sendMessageBtn.Name = "sendMessageBtn";
            sendMessageBtn.Size = new Size(79, 35);
            sendMessageBtn.TabIndex = 35;
            sendMessageBtn.Text = "Send This";
            sendMessageBtn.UseVisualStyleBackColor = false;
            sendMessageBtn.Click += sendMessageBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(keyAddButton);
            panel3.Controls.Add(keyTextBox);
            panel3.Controls.Add(keyDeleteButton);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 125);
            panel3.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 29);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 39;
            label9.Text = "Delete checked keys:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 38;
            label8.Text = "List Opitons:";
            // 
            // label14
            // 
            label14.Location = new Point(18, 65);
            label14.Name = "label14";
            label14.Size = new Size(121, 42);
            label14.TabIndex = 44;
            label14.Text = "Add a key to list:";
            label14.Click += label14_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(242, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 33;
            label5.Text = "to";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(convertReqTextBox);
            panel2.Controls.Add(convertResultTextBox);
            panel2.Controls.Add(convertReqCb);
            panel2.Controls.Add(convertResultCb);
            panel2.Location = new Point(494, 442);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 171);
            panel2.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(198, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 34;
            label6.Text = "CONVERTOR";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1329, 614);
            Controls.Add(clearLogBtn);
            Controls.Add(allSelect);
            Controls.Add(ipPortPanel);
            Controls.Add(panel2);
            Controls.Add(keyList);
            Controls.Add(resultView);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "a";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)resultView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ipPortPanel.ResumeLayout(false);
            ipPortPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private RichTextBox convertReqTextBox;
        private RichTextBox convertResultTextBox;
        private ComboBox convertResultCb;
        private ComboBox convertReqCb;
        private System.Windows.Forms.Timer ConnectionTimer;
        private CheckBox endianCheck;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Response;
        private DataGridViewTextBoxColumn Formated;
        private Panel panel1;
        private Label label5;
        private Button sendMessageBtn;
        private TextBox sendMessageBox;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label10;
        private Panel panel3;
        private Panel panel4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private Panel panel5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem convertToolStripMenuItem;
        private ToolStripMenuItem toHexToolStripMenuItem;
        private ToolStripMenuItem toToolStripMenuItem;
        private ToolStripMenuItem copyTheCellToolStripMenuItem;
        private ToolStripMenuItem toToolStripMenuItem1;
        private ToolStripMenuItem toUtf8StringToolStripMenuItem;
        private ToolStripMenuItem toASCIIStringToolStripMenuItem;
        private ToolStripMenuItem toFloatToolStripMenuItem;
        private ToolStripMenuItem toDoubleToolStripMenuItem;
        private ToolStripMenuItem toInt16ToolStripMenuItem;
        private ToolStripMenuItem toInt32ToolStripMenuItem;
        private ToolStripMenuItem toUInt16ToolStripMenuItem;
        private ToolStripMenuItem toUInt32ToolStripMenuItem;
        private ToolStripMenuItem toInt64ToolStripMenuItem;
        private ToolStripMenuItem toUInt64ToolStripMenuItem;
    }
}
