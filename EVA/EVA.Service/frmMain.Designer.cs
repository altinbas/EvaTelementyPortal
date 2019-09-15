namespace EVA.Service
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button chkSendNetwork;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpStartService = new System.Windows.Forms.GroupBox();
            this.chcSendData = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbSelectPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.grpSemdData = new System.Windows.Forms.GroupBox();
            this.grpMasterData = new System.Windows.Forms.GroupBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.lblActiveCurrent = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblDifference3 = new System.Windows.Forms.Label();
            this.lblDifference2 = new System.Windows.Forms.Label();
            this.lblDifference1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblMinCell3 = new System.Windows.Forms.Label();
            this.lblMinCell2 = new System.Windows.Forms.Label();
            this.lblMinCell1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMaxCell3 = new System.Windows.Forms.Label();
            this.lblMaxCell2 = new System.Windows.Forms.Label();
            this.lblMaxCell1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblBatteryHeatC3 = new System.Windows.Forms.Label();
            this.lblBatteryHeatC2 = new System.Windows.Forms.Label();
            this.lblBatteryHeatC1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.ggBatteryLevel = new ns1.BunifuCircleProgressbar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.ggVelocity = new ns1.BunifuGauge();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.btnLog = new ns1.BunifuFlatButton();
            chkSendNetwork = new System.Windows.Forms.Button();
            this.grpStartService.SuspendLayout();
            this.grpConsole.SuspendLayout();
            this.grpSemdData.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSendNetwork
            // 
            chkSendNetwork.BackColor = System.Drawing.Color.Black;
            chkSendNetwork.Enabled = false;
            chkSendNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            chkSendNetwork.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkSendNetwork.Location = new System.Drawing.Point(24, 105);
            chkSendNetwork.Name = "chkSendNetwork";
            chkSendNetwork.Size = new System.Drawing.Size(228, 33);
            chkSendNetwork.TabIndex = 6;
            chkSendNetwork.Text = "Send data to network";
            chkSendNetwork.UseVisualStyleBackColor = false;
            chkSendNetwork.Click += new System.EventHandler(this.BtnSendData_Click);
            // 
            // grpStartService
            // 
            this.grpStartService.Controls.Add(this.chcSendData);
            this.grpStartService.Controls.Add(this.btnDisconnect);
            this.grpStartService.Controls.Add(this.lblStatus);
            this.grpStartService.Controls.Add(this.label1);
            this.grpStartService.Controls.Add(this.btnStart);
            this.grpStartService.Controls.Add(this.btnRefresh);
            this.grpStartService.Controls.Add(this.cmbSelectPort);
            this.grpStartService.Controls.Add(this.lblPort);
            this.grpStartService.ForeColor = System.Drawing.Color.White;
            this.grpStartService.Location = new System.Drawing.Point(24, 79);
            this.grpStartService.Name = "grpStartService";
            this.grpStartService.Size = new System.Drawing.Size(273, 268);
            this.grpStartService.TabIndex = 0;
            this.grpStartService.TabStop = false;
            this.grpStartService.Text = "Service Settings";
            // 
            // chcSendData
            // 
            this.chcSendData.AutoSize = true;
            this.chcSendData.Checked = true;
            this.chcSendData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcSendData.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(11)));
            this.chcSendData.Location = new System.Drawing.Point(61, 89);
            this.chcSendData.Name = "chcSendData";
            this.chcSendData.Size = new System.Drawing.Size(164, 21);
            this.chcSendData.TabIndex = 7;
            this.chcSendData.Text = "Send data to network";
            this.chcSendData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chcSendData.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Black;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(20, 208);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(232, 33);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.lblStatus.Location = new System.Drawing.Point(157, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "STOPPED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service Status:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(122, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Service";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(20, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // cmbSelectPort
            // 
            this.cmbSelectPort.BackColor = System.Drawing.Color.Black;
            this.cmbSelectPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectPort.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbSelectPort.FormattingEnabled = true;
            this.cmbSelectPort.Location = new System.Drawing.Point(20, 57);
            this.cmbSelectPort.Name = "cmbSelectPort";
            this.cmbSelectPort.Size = new System.Drawing.Size(232, 26);
            this.cmbSelectPort.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(17, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(87, 18);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Select Port*";
            // 
            // grpConsole
            // 
            this.grpConsole.Controls.Add(this.txtConsole);
            this.grpConsole.ForeColor = System.Drawing.Color.White;
            this.grpConsole.Location = new System.Drawing.Point(333, 79);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Size = new System.Drawing.Size(464, 435);
            this.grpConsole.TabIndex = 1;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Info;
            this.txtConsole.Location = new System.Drawing.Point(3, 16);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(458, 416);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Red;
            this.txtData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtData.Location = new System.Drawing.Point(31, 19);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(210, 80);
            this.txtData.TabIndex = 4;
            this.txtData.Text = "";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BackColor = System.Drawing.Color.Black;
            this.btnClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConsole.Location = new System.Drawing.Point(672, 520);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(102, 29);
            this.btnClearConsole.TabIndex = 3;
            this.btnClearConsole.Text = "Clear Console";
            this.btnClearConsole.UseVisualStyleBackColor = false;
            this.btnClearConsole.Click += new System.EventHandler(this.BtnClearConsole_Click);
            // 
            // grpSemdData
            // 
            this.grpSemdData.Controls.Add(chkSendNetwork);
            this.grpSemdData.Controls.Add(this.txtData);
            this.grpSemdData.ForeColor = System.Drawing.Color.White;
            this.grpSemdData.Location = new System.Drawing.Point(24, 353);
            this.grpSemdData.Name = "grpSemdData";
            this.grpSemdData.Size = new System.Drawing.Size(273, 158);
            this.grpSemdData.TabIndex = 4;
            this.grpSemdData.TabStop = false;
            this.grpSemdData.Text = "Send Data";
            // 
            // grpMasterData
            // 
            this.grpMasterData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpMasterData.Location = new System.Drawing.Point(831, 79);
            this.grpMasterData.Name = "grpMasterData";
            this.grpMasterData.Size = new System.Drawing.Size(395, 470);
            this.grpMasterData.TabIndex = 5;
            this.grpMasterData.TabStop = false;
            this.grpMasterData.Text = "Live Master Data";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.SidePanel.Controls.Add(this.lblCurrentTime);
            this.SidePanel.Controls.Add(this.btnHide);
            this.SidePanel.Controls.Add(this.btnExit);
            this.SidePanel.Controls.Add(this.btnLog);
            this.SidePanel.Controls.Add(this.bunifuFlatButton2);
            this.SidePanel.Controls.Add(this.bunifuFlatButton1);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(1266, 60);
            this.SidePanel.TabIndex = 6;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(1061, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(100, 27);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.btnHide.Image = global::EVA.Service.Properties.Resources.min_ic;
            this.btnHide.Location = new System.Drawing.Point(1203, 10);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(22, 23);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHide.TabIndex = 5;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.BtnHide_Click);
            this.btnHide.MouseLeave += new System.EventHandler(this.BtnHide_MouseLeave);
            this.btnHide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHide_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::EVA.Service.Properties.Resources.kapat;
            this.btnExit.Location = new System.Drawing.Point(1231, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnExit_MouseMove);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Dashboard";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(321, 7);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(161, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Dashboard";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Management";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(146, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(169, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Management";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(140, 60);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EVA.Service.Properties.Resources.Tasarm3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pictureBox3);
            this.pnlDashboard.Controls.Add(this.lblLeftTime);
            this.pnlDashboard.Controls.Add(this.lblActiveCurrent);
            this.pnlDashboard.Controls.Add(this.label34);
            this.pnlDashboard.Controls.Add(this.label35);
            this.pnlDashboard.Controls.Add(this.lblDifference3);
            this.pnlDashboard.Controls.Add(this.lblDifference2);
            this.pnlDashboard.Controls.Add(this.lblDifference1);
            this.pnlDashboard.Controls.Add(this.label26);
            this.pnlDashboard.Controls.Add(this.label27);
            this.pnlDashboard.Controls.Add(this.label28);
            this.pnlDashboard.Controls.Add(this.lblMinCell3);
            this.pnlDashboard.Controls.Add(this.lblMinCell2);
            this.pnlDashboard.Controls.Add(this.lblMinCell1);
            this.pnlDashboard.Controls.Add(this.label18);
            this.pnlDashboard.Controls.Add(this.label19);
            this.pnlDashboard.Controls.Add(this.label21);
            this.pnlDashboard.Controls.Add(this.lblMaxCell3);
            this.pnlDashboard.Controls.Add(this.lblMaxCell2);
            this.pnlDashboard.Controls.Add(this.lblMaxCell1);
            this.pnlDashboard.Controls.Add(this.label11);
            this.pnlDashboard.Controls.Add(this.label12);
            this.pnlDashboard.Controls.Add(this.label14);
            this.pnlDashboard.Controls.Add(this.label20);
            this.pnlDashboard.Controls.Add(this.label7);
            this.pnlDashboard.Controls.Add(this.label13);
            this.pnlDashboard.Controls.Add(this.label22);
            this.pnlDashboard.Controls.Add(this.lblBatteryHeatC3);
            this.pnlDashboard.Controls.Add(this.lblBatteryHeatC2);
            this.pnlDashboard.Controls.Add(this.lblBatteryHeatC1);
            this.pnlDashboard.Controls.Add(this.label6);
            this.pnlDashboard.Controls.Add(this.label5);
            this.pnlDashboard.Controls.Add(this.panel3);
            this.pnlDashboard.Controls.Add(this.label4);
            this.pnlDashboard.Controls.Add(this.label2);
            this.pnlDashboard.Controls.Add(this.panel2);
            this.pnlDashboard.Controls.Add(this.pictureBox2);
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Controls.Add(this.ggBatteryLevel);
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Controls.Add(this.lblVelocity);
            this.pnlDashboard.Controls.Add(this.ggVelocity);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 66);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1266, 510);
            this.pnlDashboard.TabIndex = 7;
            this.pnlDashboard.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EVA.Service.Properties.Resources.Thermometer_75_256;
            this.pictureBox3.Location = new System.Drawing.Point(804, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTime.Location = new System.Drawing.Point(511, 443);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(19, 25);
            this.lblLeftTime.TabIndex = 85;
            this.lblLeftTime.Text = "-";
            // 
            // lblActiveCurrent
            // 
            this.lblActiveCurrent.AutoSize = true;
            this.lblActiveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCurrent.Location = new System.Drawing.Point(240, 443);
            this.lblActiveCurrent.Name = "lblActiveCurrent";
            this.lblActiveCurrent.Size = new System.Drawing.Size(19, 25);
            this.lblActiveCurrent.TabIndex = 84;
            this.lblActiveCurrent.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(398, 443);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 25);
            this.label34.TabIndex = 82;
            this.label34.Text = "Left Time:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(80, 443);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 25);
            this.label35.TabIndex = 81;
            this.label35.Text = "Active Current:";
            // 
            // lblDifference3
            // 
            this.lblDifference3.AutoSize = true;
            this.lblDifference3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference3.Location = new System.Drawing.Point(1202, 411);
            this.lblDifference3.Name = "lblDifference3";
            this.lblDifference3.Size = new System.Drawing.Size(19, 25);
            this.lblDifference3.TabIndex = 80;
            this.lblDifference3.Text = "-";
            // 
            // lblDifference2
            // 
            this.lblDifference2.AutoSize = true;
            this.lblDifference2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference2.Location = new System.Drawing.Point(1202, 381);
            this.lblDifference2.Name = "lblDifference2";
            this.lblDifference2.Size = new System.Drawing.Size(19, 25);
            this.lblDifference2.TabIndex = 79;
            this.lblDifference2.Text = "-";
            // 
            // lblDifference1
            // 
            this.lblDifference1.AutoSize = true;
            this.lblDifference1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference1.Location = new System.Drawing.Point(1202, 349);
            this.lblDifference1.Name = "lblDifference1";
            this.lblDifference1.Size = new System.Drawing.Size(19, 25);
            this.lblDifference1.TabIndex = 78;
            this.lblDifference1.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1116, 415);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 25);
            this.label26.TabIndex = 77;
            this.label26.Text = "Cell 3:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1115, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 25);
            this.label27.TabIndex = 76;
            this.label27.Text = "Cell 2:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(1114, 349);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 25);
            this.label28.TabIndex = 75;
            this.label28.Text = "Cell 1:";
            // 
            // lblMinCell3
            // 
            this.lblMinCell3.AutoSize = true;
            this.lblMinCell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCell3.Location = new System.Drawing.Point(1018, 411);
            this.lblMinCell3.Name = "lblMinCell3";
            this.lblMinCell3.Size = new System.Drawing.Size(19, 25);
            this.lblMinCell3.TabIndex = 74;
            this.lblMinCell3.Text = "-";
            // 
            // lblMinCell2
            // 
            this.lblMinCell2.AutoSize = true;
            this.lblMinCell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCell2.Location = new System.Drawing.Point(1018, 381);
            this.lblMinCell2.Name = "lblMinCell2";
            this.lblMinCell2.Size = new System.Drawing.Size(19, 25);
            this.lblMinCell2.TabIndex = 73;
            this.lblMinCell2.Text = "-";
            // 
            // lblMinCell1
            // 
            this.lblMinCell1.AutoSize = true;
            this.lblMinCell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCell1.Location = new System.Drawing.Point(1018, 349);
            this.lblMinCell1.Name = "lblMinCell1";
            this.lblMinCell1.Size = new System.Drawing.Size(19, 25);
            this.lblMinCell1.TabIndex = 72;
            this.lblMinCell1.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(932, 415);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 25);
            this.label18.TabIndex = 71;
            this.label18.Text = "Cell 3:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(931, 381);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 25);
            this.label19.TabIndex = 70;
            this.label19.Text = "Cell 2:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(930, 349);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 25);
            this.label21.TabIndex = 69;
            this.label21.Text = "Cell 1:";
            // 
            // lblMaxCell3
            // 
            this.lblMaxCell3.AutoSize = true;
            this.lblMaxCell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCell3.Location = new System.Drawing.Point(822, 411);
            this.lblMaxCell3.Name = "lblMaxCell3";
            this.lblMaxCell3.Size = new System.Drawing.Size(19, 25);
            this.lblMaxCell3.TabIndex = 68;
            this.lblMaxCell3.Text = "-";
            // 
            // lblMaxCell2
            // 
            this.lblMaxCell2.AutoSize = true;
            this.lblMaxCell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCell2.Location = new System.Drawing.Point(822, 381);
            this.lblMaxCell2.Name = "lblMaxCell2";
            this.lblMaxCell2.Size = new System.Drawing.Size(19, 25);
            this.lblMaxCell2.TabIndex = 67;
            this.lblMaxCell2.Text = "-";
            // 
            // lblMaxCell1
            // 
            this.lblMaxCell1.AutoSize = true;
            this.lblMaxCell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCell1.Location = new System.Drawing.Point(822, 349);
            this.lblMaxCell1.Name = "lblMaxCell1";
            this.lblMaxCell1.Size = new System.Drawing.Size(19, 25);
            this.lblMaxCell1.TabIndex = 66;
            this.lblMaxCell1.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(736, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Cell 3:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(735, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Cell 2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(734, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 25);
            this.label14.TabIndex = 63;
            this.label14.Text = "Cell 1:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1104, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 25);
            this.label20.TabIndex = 62;
            this.label20.Text = "Difference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Min Voltage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(724, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "Max Voltage";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(990, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 29);
            this.label22.TabIndex = 41;
            this.label22.Text = "Heat";
            // 
            // lblBatteryHeatC3
            // 
            this.lblBatteryHeatC3.AutoSize = true;
            this.lblBatteryHeatC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryHeatC3.Location = new System.Drawing.Point(1076, 225);
            this.lblBatteryHeatC3.Name = "lblBatteryHeatC3";
            this.lblBatteryHeatC3.Size = new System.Drawing.Size(19, 25);
            this.lblBatteryHeatC3.TabIndex = 17;
            this.lblBatteryHeatC3.Text = "-";
            // 
            // lblBatteryHeatC2
            // 
            this.lblBatteryHeatC2.AutoSize = true;
            this.lblBatteryHeatC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryHeatC2.Location = new System.Drawing.Point(1076, 195);
            this.lblBatteryHeatC2.Name = "lblBatteryHeatC2";
            this.lblBatteryHeatC2.Size = new System.Drawing.Size(19, 25);
            this.lblBatteryHeatC2.TabIndex = 16;
            this.lblBatteryHeatC2.Text = "-";
            // 
            // lblBatteryHeatC1
            // 
            this.lblBatteryHeatC1.AutoSize = true;
            this.lblBatteryHeatC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryHeatC1.Location = new System.Drawing.Point(1076, 163);
            this.lblBatteryHeatC1.Name = "lblBatteryHeatC1";
            this.lblBatteryHeatC1.Size = new System.Drawing.Size(19, 25);
            this.lblBatteryHeatC1.TabIndex = 12;
            this.lblBatteryHeatC1.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(990, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cell 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(989, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cell 2:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(737, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(988, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cell 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Battery";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(703, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 480);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EVA.Service.Properties.Resources._battery_beyaz2;
            this.pictureBox2.Location = new System.Drawing.Point(482, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBatteryLevel);
            this.panel1.Location = new System.Drawing.Point(465, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 66);
            this.panel1.TabIndex = 4;
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLevel.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblBatteryLevel.Location = new System.Drawing.Point(24, 4);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(84, 37);
            this.lblBatteryLevel.TabIndex = 0;
            this.lblBatteryLevel.Text = "75%";
            // 
            // ggBatteryLevel
            // 
            this.ggBatteryLevel.animated = false;
            this.ggBatteryLevel.animationIterval = 5;
            this.ggBatteryLevel.animationSpeed = 300;
            this.ggBatteryLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ggBatteryLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ggBatteryLevel.BackgroundImage")));
            this.ggBatteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ggBatteryLevel.ForeColor = System.Drawing.Color.SeaGreen;
            this.ggBatteryLevel.LabelVisible = true;
            this.ggBatteryLevel.LineProgressThickness = 8;
            this.ggBatteryLevel.LineThickness = 5;
            this.ggBatteryLevel.Location = new System.Drawing.Point(391, 80);
            this.ggBatteryLevel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ggBatteryLevel.MaxValue = 100;
            this.ggBatteryLevel.Name = "ggBatteryLevel";
            this.ggBatteryLevel.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ggBatteryLevel.ProgressColor = System.Drawing.Color.SeaGreen;
            this.ggBatteryLevel.Size = new System.Drawing.Size(273, 273);
            this.ggBatteryLevel.TabIndex = 3;
            this.ggBatteryLevel.Value = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocity";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocity.Location = new System.Drawing.Point(157, 274);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(60, 42);
            this.lblVelocity.TabIndex = 1;
            this.lblVelocity.Text = "75";
            // 
            // ggVelocity
            // 
            this.ggVelocity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ggVelocity.BackgroundImage")));
            this.ggVelocity.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ggVelocity.Location = new System.Drawing.Point(27, 65);
            this.ggVelocity.Margin = new System.Windows.Forms.Padding(6);
            this.ggVelocity.Name = "ggVelocity";
            this.ggVelocity.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.ggVelocity.ProgressColor1 = System.Drawing.Color.Green;
            this.ggVelocity.ProgressColor2 = System.Drawing.Color.Red;
            this.ggVelocity.Size = new System.Drawing.Size(312, 263);
            this.ggVelocity.TabIndex = 0;
            this.ggVelocity.Thickness = 30;
            this.ggVelocity.Value = 75;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.SidePanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnLog
            // 
            this.btnLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLog.BorderRadius = 0;
            this.btnLog.ButtonText = "Logs";
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLog.Iconimage")));
            this.btnLog.Iconimage_right = null;
            this.btnLog.Iconimage_right_Selected = null;
            this.btnLog.Iconimage_Selected = null;
            this.btnLog.IconMarginLeft = 0;
            this.btnLog.IconMarginRight = 0;
            this.btnLog.IconRightVisible = true;
            this.btnLog.IconRightZoom = 0D;
            this.btnLog.IconVisible = true;
            this.btnLog.IconZoom = 90D;
            this.btnLog.IsTab = false;
            this.btnLog.Location = new System.Drawing.Point(465, 7);
            this.btnLog.Name = "btnLog";
            this.btnLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.btnLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.btnLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLog.selected = false;
            this.btnLog.Size = new System.Drawing.Size(161, 48);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Logs";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Textcolor = System.Drawing.Color.White;
            this.btnLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1266, 576);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.grpMasterData);
            this.Controls.Add(this.grpSemdData);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpStartService);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 550);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eva Team";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpStartService.ResumeLayout(false);
            this.grpStartService.PerformLayout();
            this.grpConsole.ResumeLayout(false);
            this.grpSemdData.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStartService;
        private System.Windows.Forms.ComboBox cmbSelectPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.GroupBox grpSemdData;
        private System.Windows.Forms.GroupBox grpMasterData;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        public ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblVelocity;
        private ns1.BunifuGauge ggVelocity;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuCircleProgressbar ggBatteryLevel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBatteryLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBatteryHeatC3;
        private System.Windows.Forms.Label lblBatteryHeatC2;
        private System.Windows.Forms.Label lblBatteryHeatC1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLeftTime;
        private System.Windows.Forms.Label lblActiveCurrent;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblDifference3;
        private System.Windows.Forms.Label lblDifference2;
        private System.Windows.Forms.Label lblDifference1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblMinCell3;
        private System.Windows.Forms.Label lblMinCell2;
        private System.Windows.Forms.Label lblMinCell1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMaxCell3;
        private System.Windows.Forms.Label lblMaxCell2;
        private System.Windows.Forms.Label lblMaxCell1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.CheckBox chcSendData;
        private ns1.BunifuFlatButton btnLog;
    }
}

