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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpStartService = new System.Windows.Forms.GroupBox();
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
            this.btnSendData = new System.Windows.Forms.Button();
            this.grpSemdData = new System.Windows.Forms.GroupBox();
            this.grpMasterData = new System.Windows.Forms.GroupBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblMinCell = new System.Windows.Forms.Label();
            this.lblMaxCell = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.lblActiveCurrent = new System.Windows.Forms.Label();
            this.lblBatteryHeat = new System.Windows.Forms.Label();
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
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.grpStartService.SuspendLayout();
            this.grpConsole.SuspendLayout();
            this.grpSemdData.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStartService
            // 
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
            this.grpStartService.Size = new System.Drawing.Size(273, 236);
            this.grpStartService.TabIndex = 0;
            this.grpStartService.TabStop = false;
            this.grpStartService.Text = "Service Settings";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Black;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(20, 180);
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
            this.lblStatus.Location = new System.Drawing.Point(157, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "STOPPED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 144);
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
            this.btnStart.Location = new System.Drawing.Point(122, 97);
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
            this.btnRefresh.Location = new System.Drawing.Point(20, 97);
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
            this.grpConsole.Location = new System.Drawing.Point(313, 79);
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
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.Black;
            this.btnSendData.Enabled = false;
            this.btnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendData.Location = new System.Drawing.Point(24, 105);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(228, 33);
            this.btnSendData.TabIndex = 6;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.BtnSendData_Click);
            // 
            // grpSemdData
            // 
            this.grpSemdData.Controls.Add(this.btnSendData);
            this.grpSemdData.Controls.Add(this.txtData);
            this.grpSemdData.ForeColor = System.Drawing.Color.White;
            this.grpSemdData.Location = new System.Drawing.Point(24, 321);
            this.grpSemdData.Name = "grpSemdData";
            this.grpSemdData.Size = new System.Drawing.Size(273, 148);
            this.grpSemdData.TabIndex = 4;
            this.grpSemdData.TabStop = false;
            this.grpSemdData.Text = "Send Data";
            // 
            // grpMasterData
            // 
            this.grpMasterData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpMasterData.Location = new System.Drawing.Point(781, 79);
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
            this.SidePanel.Controls.Add(this.bunifuFlatButton2);
            this.SidePanel.Controls.Add(this.bunifuFlatButton1);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(1200, 60);
            this.SidePanel.TabIndex = 6;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.btnHide.Image = global::EVA.Service.Properties.Resources.min_ic;
            this.btnHide.Location = new System.Drawing.Point(1132, 10);
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
            this.btnExit.Location = new System.Drawing.Point(1160, 9);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(324, 7);
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
            this.pnlDashboard.Controls.Add(this.lblDifference);
            this.pnlDashboard.Controls.Add(this.lblMinCell);
            this.pnlDashboard.Controls.Add(this.lblMaxCell);
            this.pnlDashboard.Controls.Add(this.label19);
            this.pnlDashboard.Controls.Add(this.label20);
            this.pnlDashboard.Controls.Add(this.label21);
            this.pnlDashboard.Controls.Add(this.lblLeftTime);
            this.pnlDashboard.Controls.Add(this.lblActiveCurrent);
            this.pnlDashboard.Controls.Add(this.lblBatteryHeat);
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
            this.pnlDashboard.Location = new System.Drawing.Point(0, 61);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1200, 515);
            this.pnlDashboard.TabIndex = 7;
            this.pnlDashboard.Visible = false;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference.Location = new System.Drawing.Point(975, 352);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(19, 25);
            this.lblDifference.TabIndex = 26;
            this.lblDifference.Text = "-";
            // 
            // lblMinCell
            // 
            this.lblMinCell.AutoSize = true;
            this.lblMinCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCell.Location = new System.Drawing.Point(975, 322);
            this.lblMinCell.Name = "lblMinCell";
            this.lblMinCell.Size = new System.Drawing.Size(19, 25);
            this.lblMinCell.TabIndex = 25;
            this.lblMinCell.Text = "-";
            // 
            // lblMaxCell
            // 
            this.lblMaxCell.AutoSize = true;
            this.lblMaxCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCell.Location = new System.Drawing.Point(975, 290);
            this.lblMaxCell.Name = "lblMaxCell";
            this.lblMaxCell.Size = new System.Drawing.Size(19, 25);
            this.lblMaxCell.TabIndex = 21;
            this.lblMaxCell.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(907, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 25);
            this.label19.TabIndex = 20;
            this.label19.Text = "Fark:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(852, 322);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 25);
            this.label20.TabIndex = 19;
            this.label20.Text = "Min Hücre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(846, 290);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 25);
            this.label21.TabIndex = 18;
            this.label21.Text = "Max Hücre:";
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTime.Location = new System.Drawing.Point(981, 194);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(19, 25);
            this.lblLeftTime.TabIndex = 17;
            this.lblLeftTime.Text = "-";
            // 
            // lblActiveCurrent
            // 
            this.lblActiveCurrent.AutoSize = true;
            this.lblActiveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCurrent.Location = new System.Drawing.Point(981, 164);
            this.lblActiveCurrent.Name = "lblActiveCurrent";
            this.lblActiveCurrent.Size = new System.Drawing.Size(19, 25);
            this.lblActiveCurrent.TabIndex = 16;
            this.lblActiveCurrent.Text = "-";
            // 
            // lblBatteryHeat
            // 
            this.lblBatteryHeat.AutoSize = true;
            this.lblBatteryHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryHeat.Location = new System.Drawing.Point(981, 132);
            this.lblBatteryHeat.Name = "lblBatteryHeat";
            this.lblBatteryHeat.Size = new System.Drawing.Size(19, 25);
            this.lblBatteryHeat.TabIndex = 12;
            this.lblBatteryHeat.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(850, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kalan Süre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(832, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Çekilen Akım:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(839, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(883, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sıcaklık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(842, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Batarya";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(774, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 480);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EVA.Service.Properties.Resources._battery_beyaz2;
            this.pictureBox2.Location = new System.Drawing.Point(536, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBatteryLevel);
            this.panel1.Location = new System.Drawing.Point(519, 213);
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
            this.ggBatteryLevel.Location = new System.Drawing.Point(445, 111);
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
            this.label3.Location = new System.Drawing.Point(150, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocity";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocity.Location = new System.Drawing.Point(128, 292);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(60, 42);
            this.lblVelocity.TabIndex = 1;
            this.lblVelocity.Text = "75";
            // 
            // ggVelocity
            // 
            this.ggVelocity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ggVelocity.BackgroundImage")));
            this.ggVelocity.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ggVelocity.Location = new System.Drawing.Point(48, 96);
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
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(990, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(100, 27);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1200, 576);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.grpMasterData);
            this.Controls.Add(this.grpSemdData);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpStartService);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnSendData;
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
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblMinCell;
        private System.Windows.Forms.Label lblMaxCell;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblLeftTime;
        private System.Windows.Forms.Label lblActiveCurrent;
        private System.Windows.Forms.Label lblBatteryHeat;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmrTime;
    }
}

