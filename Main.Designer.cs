namespace Tweak_Installer {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchTweak = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ipAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuWebClient1 = new Bunifu.Framework.UI.BunifuWebClient(this.components);
            this.search = new System.Windows.Forms.Timer(this.components);
            this.checkConnection = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.rootPassword = new System.Windows.Forms.TextBox();
            this.loadLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.installFromFile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.uninstallFromFile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.loadLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 30);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(785, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(812, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "TWEAK INSTALLER";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(297, 12);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 4;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuiOSSwitch1);
            this.panel1.Location = new System.Drawing.Point(0, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 44);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(279, 20);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Automatically Respring and UICache";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchTweak
            // 
            this.searchTweak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.searchTweak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTweak.BackgroundImage")));
            this.searchTweak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTweak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.searchTweak.Icon = ((System.Drawing.Image)(resources.GetObject("searchTweak.Icon")));
            this.searchTweak.Location = new System.Drawing.Point(269, 47);
            this.searchTweak.Name = "searchTweak";
            this.searchTweak.Size = new System.Drawing.Size(304, 42);
            this.searchTweak.TabIndex = 14;
            this.searchTweak.text = "Search For Tweaks (recommended)";
            this.searchTweak.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.searchTweak.Enter += new System.EventHandler(this.searchTweak_Enter);
            this.searchTweak.Leave += new System.EventHandler(this.searchTweak_Leave);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(275, 53);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 15;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(283, 194);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(276, 24);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "CONNECT YOUR DEVICE";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Connect";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(301, 399);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Text = "Connect";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ipAddress.ForeColor = System.Drawing.Color.Silver;
            this.ipAddress.HintForeColor = System.Drawing.Color.Silver;
            this.ipAddress.HintText = "Device IP Address";
            this.ipAddress.isPassword = false;
            this.ipAddress.LineFocusedColor = System.Drawing.Color.Gray;
            this.ipAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.ipAddress.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ipAddress.LineThickness = 3;
            this.ipAddress.Location = new System.Drawing.Point(232, 262);
            this.ipAddress.Margin = new System.Windows.Forms.Padding(4);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(379, 33);
            this.ipAddress.TabIndex = 90;
            this.ipAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuWebClient1
            // 
            this.bunifuWebClient1.AllowReadStreamBuffering = false;
            this.bunifuWebClient1.AllowWriteStreamBuffering = false;
            this.bunifuWebClient1.BaseAddress = "";
            this.bunifuWebClient1.CachePolicy = null;
            this.bunifuWebClient1.Credentials = null;
            this.bunifuWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient1.Encoding")));
            this.bunifuWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient1.Headers")));
            this.bunifuWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient1.QueryString")));
            this.bunifuWebClient1.UseDefaultCredentials = false;
            // 
            // search
            // 
            this.search.Enabled = true;
            this.search.Interval = 1000;
            this.search.Tick += new System.EventHandler(this.search_Tick);
            // 
            // checkConnection
            // 
            this.checkConnection.Interval = 5000;
            this.checkConnection.Tick += new System.EventHandler(this.checkConnection_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Location = new System.Drawing.Point(12, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 487);
            this.panel3.TabIndex = 21;
            this.panel3.Visible = false;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(368, 22);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "No Results";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(232, 349);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(379, 10);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // rootPassword
            // 
            this.rootPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.rootPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rootPassword.ForeColor = System.Drawing.Color.Silver;
            this.rootPassword.Location = new System.Drawing.Point(239, 330);
            this.rootPassword.Multiline = true;
            this.rootPassword.Name = "rootPassword";
            this.rootPassword.Size = new System.Drawing.Size(368, 23);
            this.rootPassword.TabIndex = 91;
            this.rootPassword.Text = "Root Password";
            this.rootPassword.Enter += new System.EventHandler(this.rootPassword_Enter);
            this.rootPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.rootPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rootPassword_KeyUp);
            this.rootPassword.Leave += new System.EventHandler(this.rootPassword_Leave);
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.loadLabel.Location = new System.Drawing.Point(162, 8);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(0, 15);
            this.loadLabel.TabIndex = 23;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Special Credits";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(618, 1);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(212, 43);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // installFromFile
            // 
            this.installFromFile.ActiveBorderThickness = 1;
            this.installFromFile.ActiveCornerRadius = 20;
            this.installFromFile.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.installFromFile.ActiveForecolor = System.Drawing.Color.White;
            this.installFromFile.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.installFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.installFromFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("installFromFile.BackgroundImage")));
            this.installFromFile.ButtonText = "install from file";
            this.installFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installFromFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installFromFile.ForeColor = System.Drawing.Color.White;
            this.installFromFile.IdleBorderThickness = 1;
            this.installFromFile.IdleCornerRadius = 20;
            this.installFromFile.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.installFromFile.IdleForecolor = System.Drawing.Color.White;
            this.installFromFile.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.installFromFile.Location = new System.Drawing.Point(283, 95);
            this.installFromFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.installFromFile.Name = "installFromFile";
            this.installFromFile.Size = new System.Drawing.Size(134, 32);
            this.installFromFile.TabIndex = 14;
            this.installFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.installFromFile.Visible = false;
            this.installFromFile.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // uninstallFromFile
            // 
            this.uninstallFromFile.ActiveBorderThickness = 1;
            this.uninstallFromFile.ActiveCornerRadius = 20;
            this.uninstallFromFile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstallFromFile.ActiveForecolor = System.Drawing.Color.White;
            this.uninstallFromFile.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstallFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.uninstallFromFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uninstallFromFile.BackgroundImage")));
            this.uninstallFromFile.ButtonText = "uninstall from file";
            this.uninstallFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallFromFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallFromFile.ForeColor = System.Drawing.Color.White;
            this.uninstallFromFile.IdleBorderThickness = 1;
            this.uninstallFromFile.IdleCornerRadius = 20;
            this.uninstallFromFile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstallFromFile.IdleForecolor = System.Drawing.Color.White;
            this.uninstallFromFile.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstallFromFile.Location = new System.Drawing.Point(425, 95);
            this.uninstallFromFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uninstallFromFile.Name = "uninstallFromFile";
            this.uninstallFromFile.Size = new System.Drawing.Size(134, 32);
            this.uninstallFromFile.TabIndex = 24;
            this.uninstallFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uninstallFromFile.Visible = false;
            this.uninstallFromFile.Click += new System.EventHandler(this.bunifuThinButton22_Click_1);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Electra Working Tweaks";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(362, 1);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(249, 43);
            this.bunifuThinButton22.TabIndex = 14;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click_2);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(842, 679);
            this.Controls.Add(this.uninstallFromFile);
            this.Controls.Add(this.installFromFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.searchTweak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.rootPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuTextbox searchTweak;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ipAddress;
        private Bunifu.Framework.UI.BunifuWebClient bunifuWebClient1;
        private System.Windows.Forms.Timer search;
        private System.Windows.Forms.Timer checkConnection;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox rootPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel loadLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 installFromFile;
        private Bunifu.Framework.UI.BunifuThinButton2 uninstallFromFile;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}