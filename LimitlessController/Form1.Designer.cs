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
            btnSendKeys = new Button();
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
            panelIpPort = new Panel();
            btnDisconnect = new Button();
            lblConnection = new Label();
            btnConnect = new Button();
            boxPort = new TextBox();
            boxIp = new TextBox();
            lblPort = new Label();
            lblIp = new Label();
            btnStopLoop = new Button();
            chckLoop = new CheckBox();
            chckSelectAll = new CheckBox();
            clearLogBtn = new Button();
            loopColor = new Panel();
            colorTimer = new System.Windows.Forms.Timer(components);
            btnKeyAdd = new Button();
            keyDeleteButton = new Button();
            keyTextBox = new TextBox();
            keyList = new ListView();
            chckClrf = new CheckBox();
            cbSendFormat = new ComboBox();
            cbResponseFormat = new ComboBox();
            txtConvertRequest = new RichTextBox();
            txtConvertResult = new RichTextBox();
            cbConvertResult = new ComboBox();
            cbConvertReq = new ComboBox();
            ConnectionTimer = new System.Windows.Forms.Timer(components);
            chckEndian = new CheckBox();
            panel1 = new Panel();
            panelMessageOptions = new Panel();
            label15 = new Label();
            udTimeout = new NumericUpDown();
            lblOr = new Label();
            panel5 = new Panel();
            lblSendMessage = new Label();
            lblResponseFormat = new Label();
            lblMessageOptions = new Label();
            boxSendMessage = new TextBox();
            lblRequestFormat = new Label();
            lblSendKeys = new Label();
            btnSendMessage = new Button();
            panelListOptions = new Panel();
            lblDeleteKeys = new Label();
            lblKeyOptions = new Label();
            lblAddKey = new Label();
            label5 = new Label();
            panelConverter = new Panel();
            label6 = new Label();
            KEYS = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)resultView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panelIpPort.SuspendLayout();
            panel1.SuspendLayout();
            panelMessageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udTimeout).BeginInit();
            panelListOptions.SuspendLayout();
            panelConverter.SuspendLayout();
            SuspendLayout();
            // 
            // KEYS
            // 
            KEYS.Text = "KEYS";
            KEYS.Width = 300;
            // 
            // btnSendKeys
            // 
            btnSendKeys.BackColor = SystemColors.ActiveCaption;
            btnSendKeys.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSendKeys.ForeColor = SystemColors.ActiveCaptionText;
            btnSendKeys.Location = new Point(45, 368);
            btnSendKeys.Name = "btnSendKeys";
            btnSendKeys.Size = new Size(113, 58);
            btnSendKeys.TabIndex = 35;
            btnSendKeys.Text = "Send Keys";
            btnSendKeys.UseVisualStyleBackColor = false;
            btnSendKeys.Click += Send_Click;
            // 
            // resultView
            // 
            resultView.AllowUserToAddRows = false;
            resultView.AllowUserToDeleteRows = false;
            resultView.BackgroundColor = SystemColors.GradientActiveCaption;
            resultView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultView.Columns.AddRange(new DataGridViewColumn[] { Key, Response, Formated });
            resultView.ContextMenuStrip = contextMenuStrip1;
            resultView.Location = new Point(700, 0);
            resultView.Name = "resultView";
            resultView.RowHeadersWidth = 62;
            resultView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultView.Size = new Size(1190, 733);
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
            Key.Width = 75;
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
            Formated.Width = 1000;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { convertToolStripMenuItem, copyTheCellToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(190, 68);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // convertToolStripMenuItem
            // 
            convertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toHexToolStripMenuItem, toToolStripMenuItem1, toToolStripMenuItem, toUtf8StringToolStripMenuItem, toASCIIStringToolStripMenuItem, toFloatToolStripMenuItem, toDoubleToolStripMenuItem, toInt16ToolStripMenuItem, toInt32ToolStripMenuItem, toUInt16ToolStripMenuItem, toUInt32ToolStripMenuItem, toInt64ToolStripMenuItem, toUInt64ToolStripMenuItem });
            convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            convertToolStripMenuItem.Size = new Size(189, 32);
            convertToolStripMenuItem.Text = "Convert";
            // 
            // toHexToolStripMenuItem
            // 
            toHexToolStripMenuItem.Name = "toHexToolStripMenuItem";
            toHexToolStripMenuItem.Size = new Size(225, 34);
            toHexToolStripMenuItem.Text = "to Decimal";
            toHexToolStripMenuItem.Click += toDecimalToolStripMenuItem_Click;
            // 
            // toToolStripMenuItem1
            // 
            toToolStripMenuItem1.Name = "toToolStripMenuItem1";
            toToolStripMenuItem1.Size = new Size(225, 34);
            toToolStripMenuItem1.Text = "to Hex";
            toToolStripMenuItem1.Click += toHexStripMenuItem1_Click;
            // 
            // toToolStripMenuItem
            // 
            toToolStripMenuItem.Name = "toToolStripMenuItem";
            toToolStripMenuItem.Size = new Size(225, 34);
            toToolStripMenuItem.Text = "to Binary";
            toToolStripMenuItem.Click += toToolStripMenuItem_Click;
            // 
            // toUtf8StringToolStripMenuItem
            // 
            toUtf8StringToolStripMenuItem.Name = "toUtf8StringToolStripMenuItem";
            toUtf8StringToolStripMenuItem.Size = new Size(225, 34);
            toUtf8StringToolStripMenuItem.Text = "to Utf8String";
            toUtf8StringToolStripMenuItem.Click += toUtf8StringToolStripMenuItem_Click;
            // 
            // toASCIIStringToolStripMenuItem
            // 
            toASCIIStringToolStripMenuItem.Name = "toASCIIStringToolStripMenuItem";
            toASCIIStringToolStripMenuItem.Size = new Size(225, 34);
            toASCIIStringToolStripMenuItem.Text = "to ASCIIString";
            toASCIIStringToolStripMenuItem.Click += toASCIIStringToolStripMenuItem_Click;
            // 
            // toFloatToolStripMenuItem
            // 
            toFloatToolStripMenuItem.Name = "toFloatToolStripMenuItem";
            toFloatToolStripMenuItem.Size = new Size(225, 34);
            toFloatToolStripMenuItem.Text = "to Float";
            toFloatToolStripMenuItem.Click += toFloatToolStripMenuItem_Click;
            // 
            // toDoubleToolStripMenuItem
            // 
            toDoubleToolStripMenuItem.Name = "toDoubleToolStripMenuItem";
            toDoubleToolStripMenuItem.Size = new Size(225, 34);
            toDoubleToolStripMenuItem.Text = "to Double";
            toDoubleToolStripMenuItem.Click += toDoubleToolStripMenuItem_Click;
            // 
            // toInt16ToolStripMenuItem
            // 
            toInt16ToolStripMenuItem.Name = "toInt16ToolStripMenuItem";
            toInt16ToolStripMenuItem.Size = new Size(225, 34);
            toInt16ToolStripMenuItem.Text = "to Int16";
            toInt16ToolStripMenuItem.Click += toInt16ToolStripMenuItem_Click;
            // 
            // toInt32ToolStripMenuItem
            // 
            toInt32ToolStripMenuItem.Name = "toInt32ToolStripMenuItem";
            toInt32ToolStripMenuItem.Size = new Size(225, 34);
            toInt32ToolStripMenuItem.Text = "to Int32";
            toInt32ToolStripMenuItem.Click += toInt32ToolStripMenuItem_Click;
            // 
            // toUInt16ToolStripMenuItem
            // 
            toUInt16ToolStripMenuItem.Name = "toUInt16ToolStripMenuItem";
            toUInt16ToolStripMenuItem.Size = new Size(225, 34);
            toUInt16ToolStripMenuItem.Text = "to UInt16";
            toUInt16ToolStripMenuItem.Click += toUInt16ToolStripMenuItem_Click;
            // 
            // toUInt32ToolStripMenuItem
            // 
            toUInt32ToolStripMenuItem.Name = "toUInt32ToolStripMenuItem";
            toUInt32ToolStripMenuItem.Size = new Size(225, 34);
            toUInt32ToolStripMenuItem.Text = "to UInt 32";
            toUInt32ToolStripMenuItem.Click += toUInt32ToolStripMenuItem_Click;
            // 
            // toInt64ToolStripMenuItem
            // 
            toInt64ToolStripMenuItem.Name = "toInt64ToolStripMenuItem";
            toInt64ToolStripMenuItem.Size = new Size(225, 34);
            toInt64ToolStripMenuItem.Text = "to Int64";
            toInt64ToolStripMenuItem.Click += toInt64ToolStripMenuItem_Click;
            // 
            // toUInt64ToolStripMenuItem
            // 
            toUInt64ToolStripMenuItem.Name = "toUInt64ToolStripMenuItem";
            toUInt64ToolStripMenuItem.Size = new Size(225, 34);
            toUInt64ToolStripMenuItem.Text = "to UInt64";
            toUInt64ToolStripMenuItem.Click += toUInt64ToolStripMenuItem_Click;
            // 
            // copyTheCellToolStripMenuItem
            // 
            copyTheCellToolStripMenuItem.Name = "copyTheCellToolStripMenuItem";
            copyTheCellToolStripMenuItem.Size = new Size(189, 32);
            copyTheCellToolStripMenuItem.Text = "Copy the Cell";
            copyTheCellToolStripMenuItem.Click += copyTheCellToolStripMenuItem_Click;
            // 
            // panelIpPort
            // 
            panelIpPort.BackColor = SystemColors.ActiveCaption;
            panelIpPort.BorderStyle = BorderStyle.Fixed3D;
            panelIpPort.Controls.Add(btnDisconnect);
            panelIpPort.Controls.Add(lblConnection);
            panelIpPort.Controls.Add(btnConnect);
            panelIpPort.Controls.Add(boxPort);
            panelIpPort.Controls.Add(boxIp);
            panelIpPort.Controls.Add(lblPort);
            panelIpPort.Controls.Add(lblIp);
            panelIpPort.Location = new Point(1427, 737);
            panelIpPort.Name = "panelIpPort";
            panelIpPort.Size = new Size(470, 282);
            panelIpPort.TabIndex = 11;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Red;
            btnDisconnect.Location = new Point(259, 178);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(116, 57);
            btnDisconnect.TabIndex = 14;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += button3_Click;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.BackColor = Color.Red;
            lblConnection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblConnection.Location = new Point(150, 17);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(187, 32);
            lblConnection.TabIndex = 13;
            lblConnection.Text = "DISCONNECTED";
            lblConnection.Click += label3_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.SteelBlue;
            btnConnect.Location = new Point(126, 178);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(114, 57);
            btnConnect.TabIndex = 13;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += ConnectBtn_Click;
            // 
            // boxPort
            // 
            boxPort.Location = new Point(187, 118);
            boxPort.Name = "boxPort";
            boxPort.Size = new Size(150, 31);
            boxPort.TabIndex = 13;
            // 
            // boxIp
            // 
            boxIp.Location = new Point(187, 73);
            boxIp.Name = "boxIp";
            boxIp.Size = new Size(150, 31);
            boxIp.TabIndex = 12;
            boxIp.TextChanged += ipBox_TextChanged;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(126, 132);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(44, 25);
            lblPort.TabIndex = 1;
            lblPort.Text = "Port";
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(126, 87);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(27, 25);
            lblIp.TabIndex = 0;
            lblIp.Text = "IP";
            lblIp.Click += label1_Click;
            // 
            // btnStopLoop
            // 
            btnStopLoop.BackColor = Color.FromArgb(192, 0, 0);
            btnStopLoop.Location = new Point(295, 524);
            btnStopLoop.Name = "btnStopLoop";
            btnStopLoop.Size = new Size(110, 58);
            btnStopLoop.TabIndex = 12;
            btnStopLoop.Text = "Stop Loop";
            btnStopLoop.UseVisualStyleBackColor = false;
            btnStopLoop.Click += button1_Click;
            // 
            // chckLoop
            // 
            chckLoop.AutoSize = true;
            chckLoop.BackColor = SystemColors.ActiveCaption;
            chckLoop.Location = new Point(26, 216);
            chckLoop.Name = "chckLoop";
            chckLoop.Size = new Size(84, 29);
            chckLoop.TabIndex = 13;
            chckLoop.Text = "Loop ";
            chckLoop.UseVisualStyleBackColor = false;
            chckLoop.CheckedChanged += loopCheck_CheckedChanged;
            // 
            // chckSelectAll
            // 
            chckSelectAll.AutoSize = true;
            chckSelectAll.BackColor = SystemColors.ButtonFace;
            chckSelectAll.Location = new Point(3, -2);
            chckSelectAll.Name = "chckSelectAll";
            chckSelectAll.Size = new Size(102, 29);
            chckSelectAll.TabIndex = 14;
            chckSelectAll.Text = "selectAll";
            chckSelectAll.UseVisualStyleBackColor = false;
            chckSelectAll.CheckedChanged += allSelect_CheckedChanged;
            // 
            // clearLogBtn
            // 
            clearLogBtn.BackColor = Color.Red;
            clearLogBtn.Location = new Point(700, 0);
            clearLogBtn.Name = "clearLogBtn";
            clearLogBtn.Size = new Size(60, 33);
            clearLogBtn.TabIndex = 15;
            clearLogBtn.Text = "ClearLogs";
            clearLogBtn.UseVisualStyleBackColor = false;
            clearLogBtn.Click += clearLogBtn_Click_1;
            // 
            // loopColor
            // 
            loopColor.BackColor = Color.Red;
            loopColor.Location = new Point(273, 548);
            loopColor.Name = "loopColor";
            loopColor.Size = new Size(16, 17);
            loopColor.TabIndex = 16;
            loopColor.Paint += loopColor_Paint;
            // 
            // colorTimer
            // 
            colorTimer.Tick += colorTimer_Tick;
            // 
            // btnKeyAdd
            // 
            btnKeyAdd.BackColor = SystemColors.ActiveCaption;
            btnKeyAdd.Location = new Point(243, 147);
            btnKeyAdd.Name = "btnKeyAdd";
            btnKeyAdd.Size = new Size(75, 31);
            btnKeyAdd.TabIndex = 18;
            btnKeyAdd.Text = "Add";
            btnKeyAdd.UseVisualStyleBackColor = false;
            btnKeyAdd.Click += keyAddButton_Click;
            // 
            // keyDeleteButton
            // 
            keyDeleteButton.BackColor = Color.Red;
            keyDeleteButton.Location = new Point(227, 48);
            keyDeleteButton.Name = "keyDeleteButton";
            keyDeleteButton.Size = new Size(143, 35);
            keyDeleteButton.TabIndex = 19;
            keyDeleteButton.Text = "Delete Selected";
            keyDeleteButton.UseVisualStyleBackColor = false;
            keyDeleteButton.Click += keyDeleteButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.BackColor = SystemColors.Control;
            keyTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            keyTextBox.Location = new Point(84, 147);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.PlaceholderText = "add a key..";
            keyTextBox.Size = new Size(145, 32);
            keyTextBox.TabIndex = 20;
            keyTextBox.TextChanged += textBox1_TextChanged;
            // 
            // keyList
            // 
            keyList.BackColor = SystemColors.ControlDark;
            keyList.CheckBoxes = true;
            keyList.Columns.AddRange(new ColumnHeader[] { KEYS });
            keyList.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            keyList.FullRowSelect = true;
            keyList.Location = new Point(3, -2);
            keyList.Name = "keyList";
            keyList.Size = new Size(251, 1022);
            keyList.TabIndex = 21;
            keyList.UseCompatibleStateImageBehavior = false;
            keyList.View = View.Details;
            keyList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // chckClrf
            // 
            chckClrf.AutoSize = true;
            chckClrf.BackColor = SystemColors.ActiveCaption;
            chckClrf.Location = new Point(26, 181);
            chckClrf.Name = "chckClrf";
            chckClrf.Size = new Size(117, 29);
            chckClrf.TabIndex = 22;
            chckClrf.Text = "CLRF(\\r\\n)";
            chckClrf.UseVisualStyleBackColor = false;
            // 
            // cbSendFormat
            // 
            cbSendFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSendFormat.FormattingEnabled = true;
            cbSendFormat.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            cbSendFormat.Location = new Point(26, 97);
            cbSendFormat.Name = "cbSendFormat";
            cbSendFormat.Size = new Size(173, 33);
            cbSendFormat.TabIndex = 23;
            cbSendFormat.SelectedIndexChanged += sendFormatCb_SelectedIndexChanged;
            // 
            // cbResponseFormat
            // 
            cbResponseFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResponseFormat.FormattingEnabled = true;
            cbResponseFormat.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            cbResponseFormat.Location = new Point(227, 97);
            cbResponseFormat.Name = "cbResponseFormat";
            cbResponseFormat.Size = new Size(173, 33);
            cbResponseFormat.TabIndex = 24;
            cbResponseFormat.SelectedIndexChanged += responseFormatCb_SelectedIndexChanged;
            // 
            // txtConvertRequest
            // 
            txtConvertRequest.Location = new Point(83, 78);
            txtConvertRequest.Name = "txtConvertRequest";
            txtConvertRequest.Size = new Size(253, 186);
            txtConvertRequest.TabIndex = 26;
            txtConvertRequest.Text = "";
            txtConvertRequest.TextChanged += convertReqTextBox_TextChanged;
            // 
            // txtConvertResult
            // 
            txtConvertResult.BackColor = SystemColors.Window;
            txtConvertResult.Location = new Point(387, 78);
            txtConvertResult.Name = "txtConvertResult";
            txtConvertResult.Size = new Size(233, 186);
            txtConvertResult.TabIndex = 27;
            txtConvertResult.Text = "";
            txtConvertResult.TextChanged += convertResultTextBox_TextChanged;
            // 
            // cbConvertResult
            // 
            cbConvertResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConvertResult.FormattingEnabled = true;
            cbConvertResult.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            cbConvertResult.Location = new Point(387, 40);
            cbConvertResult.Name = "cbConvertResult";
            cbConvertResult.Size = new Size(158, 33);
            cbConvertResult.TabIndex = 28;
            cbConvertResult.SelectedIndexChanged += convertResultCb_SelectedIndexChanged;
            // 
            // cbConvertReq
            // 
            cbConvertReq.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConvertReq.FormattingEnabled = true;
            cbConvertReq.Items.AddRange(new object[] { DataFormat.Decimal, DataFormat.Hex, DataFormat.Binary, DataFormat.Utf8String, DataFormat.ASCIIString, DataFormat.Float, DataFormat.Double, DataFormat.Int16, DataFormat.Int32, DataFormat.UInt16, DataFormat.UInt32, DataFormat.Int64, DataFormat.UInt64 });
            cbConvertReq.Location = new Point(184, 40);
            cbConvertReq.Name = "cbConvertReq";
            cbConvertReq.Size = new Size(153, 33);
            cbConvertReq.TabIndex = 29;
            cbConvertReq.SelectedIndexChanged += convertReqCb_SelectedIndexChanged;
            // 
            // ConnectionTimer
            // 
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            // 
            // chckEndian
            // 
            chckEndian.AutoSize = true;
            chckEndian.BackColor = SystemColors.ActiveCaption;
            chckEndian.Location = new Point(26, 146);
            chckEndian.Name = "chckEndian";
            chckEndian.Size = new Size(186, 29);
            chckEndian.TabIndex = 30;
            chckEndian.Text = "Device Big Endian?";
            chckEndian.UseVisualStyleBackColor = false;
            chckEndian.CheckedChanged += endianCheck_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panelMessageOptions);
            panel1.Controls.Add(panelListOptions);
            panel1.Location = new Point(256, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1020);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // panelMessageOptions
            // 
            panelMessageOptions.BackColor = SystemColors.ScrollBar;
            panelMessageOptions.BorderStyle = BorderStyle.Fixed3D;
            panelMessageOptions.Controls.Add(label15);
            panelMessageOptions.Controls.Add(udTimeout);
            panelMessageOptions.Controls.Add(lblOr);
            panelMessageOptions.Controls.Add(btnSendKeys);
            panelMessageOptions.Controls.Add(panel5);
            panelMessageOptions.Controls.Add(loopColor);
            panelMessageOptions.Controls.Add(lblSendMessage);
            panelMessageOptions.Controls.Add(lblResponseFormat);
            panelMessageOptions.Controls.Add(lblMessageOptions);
            panelMessageOptions.Controls.Add(btnStopLoop);
            panelMessageOptions.Controls.Add(chckEndian);
            panelMessageOptions.Controls.Add(chckLoop);
            panelMessageOptions.Controls.Add(boxSendMessage);
            panelMessageOptions.Controls.Add(lblRequestFormat);
            panelMessageOptions.Controls.Add(lblSendKeys);
            panelMessageOptions.Controls.Add(btnSendMessage);
            panelMessageOptions.Controls.Add(chckClrf);
            panelMessageOptions.Controls.Add(cbResponseFormat);
            panelMessageOptions.Controls.Add(cbSendFormat);
            panelMessageOptions.Location = new Point(3, 221);
            panelMessageOptions.Margin = new Padding(4, 5, 4, 5);
            panelMessageOptions.Name = "panelMessageOptions";
            panelMessageOptions.Size = new Size(434, 607);
            panelMessageOptions.TabIndex = 41;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(288, 153);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(112, 25);
            label15.TabIndex = 46;
            label15.Text = "Timeout MS:";
            label15.Click += label15_Click;
            // 
            // udTimeout
            // 
            udTimeout.Location = new Point(295, 181);
            udTimeout.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            udTimeout.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            udTimeout.Name = "udTimeout";
            udTimeout.Size = new Size(105, 31);
            udTimeout.TabIndex = 45;
            udTimeout.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOr.Location = new Point(183, 303);
            lblOr.Margin = new Padding(4, 0, 4, 0);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(35, 25);
            lblOr.TabIndex = 43;
            lblOr.Text = "or ";
            lblOr.Click += label13_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 600);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(436, 215);
            panel5.TabIndex = 44;
            // 
            // lblSendMessage
            // 
            lblSendMessage.AutoSize = true;
            lblSendMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSendMessage.Location = new Point(231, 290);
            lblSendMessage.Margin = new Padding(4, 0, 4, 0);
            lblSendMessage.Name = "lblSendMessage";
            lblSendMessage.Size = new Size(174, 25);
            lblSendMessage.TabIndex = 42;
            lblSendMessage.Text = "Send one message:";
            // 
            // lblResponseFormat
            // 
            lblResponseFormat.AutoSize = true;
            lblResponseFormat.Location = new Point(231, 67);
            lblResponseFormat.Margin = new Padding(4, 0, 4, 0);
            lblResponseFormat.Name = "lblResponseFormat";
            lblResponseFormat.Size = new Size(151, 25);
            lblResponseFormat.TabIndex = 37;
            lblResponseFormat.Text = "Response format:";
            // 
            // lblMessageOptions
            // 
            lblMessageOptions.AutoSize = true;
            lblMessageOptions.Location = new Point(26, 22);
            lblMessageOptions.Margin = new Padding(4, 0, 4, 0);
            lblMessageOptions.Name = "lblMessageOptions";
            lblMessageOptions.Size = new Size(200, 25);
            lblMessageOptions.TabIndex = 41;
            lblMessageOptions.Text = "Message Send Options:";
            // 
            // boxSendMessage
            // 
            boxSendMessage.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            boxSendMessage.ForeColor = SystemColors.Desktop;
            boxSendMessage.Location = new Point(231, 331);
            boxSendMessage.Name = "boxSendMessage";
            boxSendMessage.PlaceholderText = "type the message..";
            boxSendMessage.ScrollBars = ScrollBars.Vertical;
            boxSendMessage.Size = new Size(174, 32);
            boxSendMessage.TabIndex = 34;
            boxSendMessage.TextChanged += sendMessageBox_TextChanged;
            // 
            // lblRequestFormat
            // 
            lblRequestFormat.AutoSize = true;
            lblRequestFormat.Location = new Point(26, 67);
            lblRequestFormat.Margin = new Padding(4, 0, 4, 0);
            lblRequestFormat.Name = "lblRequestFormat";
            lblRequestFormat.Size = new Size(138, 25);
            lblRequestFormat.TabIndex = 36;
            lblRequestFormat.Text = "Request format:";
            // 
            // lblSendKeys
            // 
            lblSendKeys.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSendKeys.Location = new Point(26, 290);
            lblSendKeys.Margin = new Padding(4, 0, 4, 0);
            lblSendKeys.Name = "lblSendKeys";
            lblSendKeys.Size = new Size(169, 54);
            lblSendKeys.TabIndex = 40;
            lblSendKeys.Text = "Send checked keys from list:";
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = SystemColors.ActiveCaption;
            btnSendMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSendMessage.ForeColor = SystemColors.ActiveCaptionText;
            btnSendMessage.Location = new Point(292, 368);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(113, 58);
            btnSendMessage.TabIndex = 35;
            btnSendMessage.Text = "Send This";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += sendMessageBtn_Click;
            // 
            // panelListOptions
            // 
            panelListOptions.BackColor = SystemColors.ScrollBar;
            panelListOptions.BorderStyle = BorderStyle.Fixed3D;
            panelListOptions.Controls.Add(btnKeyAdd);
            panelListOptions.Controls.Add(keyTextBox);
            panelListOptions.Controls.Add(keyDeleteButton);
            panelListOptions.Controls.Add(lblDeleteKeys);
            panelListOptions.Controls.Add(lblKeyOptions);
            panelListOptions.Controls.Add(lblAddKey);
            panelListOptions.Location = new Point(3, 5);
            panelListOptions.Margin = new Padding(4, 5, 4, 5);
            panelListOptions.Name = "panelListOptions";
            panelListOptions.Size = new Size(434, 206);
            panelListOptions.TabIndex = 40;
            // 
            // lblDeleteKeys
            // 
            lblDeleteKeys.AutoSize = true;
            lblDeleteKeys.Location = new Point(45, 53);
            lblDeleteKeys.Margin = new Padding(4, 0, 4, 0);
            lblDeleteKeys.Name = "lblDeleteKeys";
            lblDeleteKeys.Size = new Size(175, 25);
            lblDeleteKeys.TabIndex = 39;
            lblDeleteKeys.Text = "Delete checked keys:";
            // 
            // lblKeyOptions
            // 
            lblKeyOptions.AutoSize = true;
            lblKeyOptions.Location = new Point(16, 16);
            lblKeyOptions.Margin = new Padding(4, 0, 4, 0);
            lblKeyOptions.Name = "lblKeyOptions";
            lblKeyOptions.Size = new Size(111, 25);
            lblKeyOptions.TabIndex = 38;
            lblKeyOptions.Text = "List Opitons:";
            // 
            // lblAddKey
            // 
            lblAddKey.Location = new Point(45, 108);
            lblAddKey.Margin = new Padding(4, 0, 4, 0);
            lblAddKey.Name = "lblAddKey";
            lblAddKey.Size = new Size(173, 36);
            lblAddKey.TabIndex = 44;
            lblAddKey.Text = "Add a key to list:";
            lblAddKey.Click += label14_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(346, 38);
            label5.Name = "label5";
            label5.Size = new Size(35, 30);
            label5.TabIndex = 33;
            label5.Text = "to";
            label5.Click += label5_Click;
            // 
            // panelConverter
            // 
            panelConverter.BackColor = SystemColors.ScrollBar;
            panelConverter.BorderStyle = BorderStyle.Fixed3D;
            panelConverter.Controls.Add(label6);
            panelConverter.Controls.Add(label5);
            panelConverter.Controls.Add(txtConvertRequest);
            panelConverter.Controls.Add(txtConvertResult);
            panelConverter.Controls.Add(cbConvertReq);
            panelConverter.Controls.Add(cbConvertResult);
            panelConverter.Location = new Point(706, 737);
            panelConverter.Name = "panelConverter";
            panelConverter.Size = new Size(715, 282);
            panelConverter.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(283, 8);
            label6.Name = "label6";
            label6.Size = new Size(145, 30);
            label6.TabIndex = 34;
            label6.Text = "CONVERTOR";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1898, 1024);
            Controls.Add(clearLogBtn);
            Controls.Add(chckSelectAll);
            Controls.Add(panelIpPort);
            Controls.Add(panelConverter);
            Controls.Add(keyList);
            Controls.Add(resultView);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "LIMITED";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)resultView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panelIpPort.ResumeLayout(false);
            panelIpPort.PerformLayout();
            panel1.ResumeLayout(false);
            panelMessageOptions.ResumeLayout(false);
            panelMessageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udTimeout).EndInit();
            panelListOptions.ResumeLayout(false);
            panelListOptions.PerformLayout();
            panelConverter.ResumeLayout(false);
            panelConverter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSendKeys;
        private DataGridView resultView;
        private Panel panelIpPort;
        private TextBox boxPort;
        private TextBox boxIp;
        private Label lblPort;
        private Label lblIp;
        private Button btnStopLoop;
        private Button btnConnect;
        private Label lblConnection;
        private CheckBox chckLoop;
        private CheckBox chckSelectAll;
        private Button clearLogBtn;
        private Panel loopColor;
        private System.Windows.Forms.Timer colorTimer;
        private Button btnKeyAdd;
        private Button keyDeleteButton;
        private TextBox keyTextBox;
        private ListView keyList;
        private Button btnDisconnect;
        private CheckBox chckClrf;
        private ComboBox cbSendFormat;
        private ComboBox cbResponseFormat;
        private RichTextBox txtConvertRequest;
        private RichTextBox txtConvertResult;
        private ComboBox cbConvertResult;
        private ComboBox cbConvertReq;
        private System.Windows.Forms.Timer ConnectionTimer;
        private CheckBox chckEndian;
        private Panel panel1;
        private Label label5;
        private Button btnSendMessage;
        private TextBox boxSendMessage;
        private Panel panelConverter;
        private Label label6;
        private Label lblResponseFormat;
        private Label lblRequestFormat;
        private Label lblDeleteKeys;
        private Label lblKeyOptions;
        private Label lblSendKeys;
        private Panel panelListOptions;
        private Panel panelMessageOptions;
        private Label lblOr;
        private Label lblSendMessage;
        private Label lblMessageOptions;
        private Label lblAddKey;
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
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Response;
        private DataGridViewTextBoxColumn Formated;
        private Label label15;
        private NumericUpDown udTimeout;
    }
}
