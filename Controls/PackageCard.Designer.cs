namespace Tweak_Installer.Controls {
    partial class PackageCard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageCard));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.description = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.size = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.version = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.author = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.display = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.uninstall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.bunifuCards1.Controls.Add(this.download);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator4);
            this.bunifuCards1.Controls.Add(this.description);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator3);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.size);
            this.bunifuCards1.Controls.Add(this.version);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.author);
            this.bunifuCards1.Controls.Add(this.display);
            this.bunifuCards1.Controls.Add(this.uninstall);
            this.bunifuCards1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCards1.ForeColor = System.Drawing.Color.White;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(522, 444);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // download
            // 
            this.download.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.download.BackColor = System.Drawing.Color.SeaGreen;
            this.download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.download.BorderRadius = 0;
            this.download.ButtonText = "INSTALL";
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.DisabledColor = System.Drawing.Color.Gray;
            this.download.Iconcolor = System.Drawing.Color.Transparent;
            this.download.Iconimage = ((System.Drawing.Image)(resources.GetObject("download.Iconimage")));
            this.download.Iconimage_right = null;
            this.download.Iconimage_right_Selected = null;
            this.download.Iconimage_Selected = null;
            this.download.IconMarginLeft = 0;
            this.download.IconMarginRight = 0;
            this.download.IconRightVisible = true;
            this.download.IconRightZoom = 0D;
            this.download.IconVisible = true;
            this.download.IconZoom = 40D;
            this.download.IsTab = false;
            this.download.Location = new System.Drawing.Point(166, 372);
            this.download.Margin = new System.Windows.Forms.Padding(6);
            this.download.Name = "download";
            this.download.Normalcolor = System.Drawing.Color.SeaGreen;
            this.download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.download.OnHoverTextColor = System.Drawing.Color.White;
            this.download.selected = false;
            this.download.Size = new System.Drawing.Size(191, 48);
            this.download.TabIndex = 12;
            this.download.Text = "INSTALL";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.download.Textcolor = System.Drawing.Color.White;
            this.download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(22, 258);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(478, 23);
            this.bunifuSeparator4.TabIndex = 11;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            this.bunifuSeparator4.Load += new System.EventHandler(this.bunifuSeparator4_Load);
            // 
            // description
            // 
            this.description.AutoEllipsis = true;
            this.description.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(38, 166);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(447, 86);
            this.description.TabIndex = 10;
            this.description.Text = "DESCRIPTION";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(94, 123);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(334, 32);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Description";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(22, 96);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(478, 24);
            this.bunifuSeparator3.TabIndex = 8;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.bunifuSeparator2.LineThickness = 277;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-692, 790);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(192, 126, 192, 126);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(12032, 535);
            this.bunifuSeparator2.TabIndex = 7;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(38, 308);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(242, 21);
            this.size.TabIndex = 6;
            this.size.Text = "SIZE";
            this.size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(38, 287);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(242, 21);
            this.version.TabIndex = 5;
            this.version.Text = "VERSION";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 335);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(478, 26);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(100, 54);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(414, 26);
            this.author.TabIndex = 2;
            this.author.Text = "AUTHOR";
            this.author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(97, 26);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(414, 26);
            this.display.TabIndex = 1;
            this.display.Text = "DISPLAY";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uninstall
            // 
            this.uninstall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uninstall.BorderRadius = 0;
            this.uninstall.ButtonText = "UNINSTALL";
            this.uninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstall.DisabledColor = System.Drawing.Color.Gray;
            this.uninstall.Iconcolor = System.Drawing.Color.Transparent;
            this.uninstall.Iconimage = ((System.Drawing.Image)(resources.GetObject("uninstall.Iconimage")));
            this.uninstall.Iconimage_right = null;
            this.uninstall.Iconimage_right_Selected = null;
            this.uninstall.Iconimage_Selected = null;
            this.uninstall.IconMarginLeft = 0;
            this.uninstall.IconMarginRight = 0;
            this.uninstall.IconRightVisible = true;
            this.uninstall.IconRightZoom = 0D;
            this.uninstall.IconVisible = true;
            this.uninstall.IconZoom = 40D;
            this.uninstall.IsTab = false;
            this.uninstall.Location = new System.Drawing.Point(270, 372);
            this.uninstall.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.uninstall.Name = "uninstall";
            this.uninstall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.uninstall.OnHoverTextColor = System.Drawing.Color.White;
            this.uninstall.selected = false;
            this.uninstall.Size = new System.Drawing.Size(191, 48);
            this.uninstall.TabIndex = 13;
            this.uninstall.Text = "UNINSTALL";
            this.uninstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uninstall.Textcolor = System.Drawing.Color.White;
            this.uninstall.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstall.Visible = false;
            this.uninstall.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // PackageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.bunifuCards1);
            this.Name = "PackageCard";
            this.Size = new System.Drawing.Size(522, 469);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel display;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel author;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel size;
        private Bunifu.Framework.UI.BunifuCustomLabel version;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel description;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuFlatButton download;
        private Bunifu.Framework.UI.BunifuFlatButton uninstall;
    }
}
