namespace Tweak_Installer
{
    partial class Main
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
            this.install = new System.Windows.Forms.Button();
            this.Uninstall = new System.Windows.Forms.Button();
            this.host = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.iplabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.respring = new System.Windows.Forms.Button();
            this.uicache = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.LinkLabel();
            this.version = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.reddit = new System.Windows.Forms.LinkLabel();
            this.creator = new System.Windows.Forms.LinkLabel();
            this.ui = new System.Windows.Forms.LinkLabel();
            this.debslnk = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.LinkLabel();
            this.autolabel = new System.Windows.Forms.Label();
            this.paypal = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.install.FlatAppearance.BorderSize = 0;
            this.install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.install.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.install.ForeColor = System.Drawing.Color.Gainsboro;
            this.install.Location = new System.Drawing.Point(12, 222);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(220, 75);
            this.install.TabIndex = 5;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = false;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // Uninstall
            // 
            this.Uninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Uninstall.FlatAppearance.BorderSize = 0;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.Uninstall.ForeColor = System.Drawing.Color.Gainsboro;
            this.Uninstall.Location = new System.Drawing.Point(238, 222);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(220, 75);
            this.Uninstall.TabIndex = 6;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = false;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // host
            // 
            this.host.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.host.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.host.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.host.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host.ForeColor = System.Drawing.Color.White;
            this.host.Location = new System.Drawing.Point(238, 23);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(200, 27);
            this.host.TabIndex = 0;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(238, 60);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(200, 27);
            this.pass.TabIndex = 1;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.iplabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iplabel.Location = new System.Drawing.Point(106, 21);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(126, 29);
            this.iplabel.TabIndex = 17;
            this.iplabel.Text = "device ip:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.passwordlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordlabel.Location = new System.Drawing.Point(46, 60);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(186, 29);
            this.passwordlabel.TabIndex = 18;
            this.passwordlabel.Text = "root password:";
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.select.FlatAppearance.BorderSize = 0;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.select.ForeColor = System.Drawing.Color.DimGray;
            this.select.Location = new System.Drawing.Point(12, 165);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(446, 51);
            this.select.TabIndex = 4;
            this.select.Text = "Select Debs, Zips and IPAs";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "example.deb";
            this.openFileDialog.Multiselect = true;
            // 
            // respring
            // 
            this.respring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.respring.FlatAppearance.BorderSize = 0;
            this.respring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.respring.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.respring.ForeColor = System.Drawing.Color.White;
            this.respring.Location = new System.Drawing.Point(12, 303);
            this.respring.Name = "respring";
            this.respring.Size = new System.Drawing.Size(220, 49);
            this.respring.TabIndex = 7;
            this.respring.Text = "Respring";
            this.respring.UseVisualStyleBackColor = false;
            this.respring.Click += new System.EventHandler(this.respring_Click);
            // 
            // uicache
            // 
            this.uicache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.uicache.FlatAppearance.BorderSize = 0;
            this.uicache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uicache.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.uicache.ForeColor = System.Drawing.Color.White;
            this.uicache.Location = new System.Drawing.Point(238, 303);
            this.uicache.Name = "uicache";
            this.uicache.Size = new System.Drawing.Size(220, 49);
            this.uicache.TabIndex = 8;
            this.uicache.Text = "Uicache";
            this.uicache.UseVisualStyleBackColor = false;
            this.uicache.Click += new System.EventHandler(this.uicache_Click);
            // 
            // auto
            // 
            this.auto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auto.AutoSize = true;
            this.auto.Checked = true;
            this.auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auto.FlatAppearance.BorderSize = 0;
            this.auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.auto.ForeColor = System.Drawing.Color.White;
            this.auto.Location = new System.Drawing.Point(59, 362);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(12, 11);
            this.auto.TabIndex = 9;
            this.auto.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.LinkColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(7, 390);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(467, 29);
            this.error.TabIndex = 10;
            this.error.TabStop = true;
            this.error.Text = "report errors / bugs / general problems";
            this.error.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.error_LinkClicked);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.version.ForeColor = System.Drawing.Color.DimGray;
            this.version.Location = new System.Drawing.Point(9, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(25, 13);
            this.version.TabIndex = 16;
            this.version.Text = "1.0";
            // 
            // twitter
            // 
            this.twitter.AutoSize = true;
            this.twitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitter.LinkColor = System.Drawing.Color.Red;
            this.twitter.Location = new System.Drawing.Point(12, 430);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(61, 13);
            this.twitter.TabIndex = 11;
            this.twitter.TabStop = true;
            this.twitter.Text = "my twitter";
            this.twitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitter_LinkClicked);
            // 
            // reddit
            // 
            this.reddit.AutoSize = true;
            this.reddit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reddit.LinkColor = System.Drawing.Color.Red;
            this.reddit.Location = new System.Drawing.Point(79, 430);
            this.reddit.Name = "reddit";
            this.reddit.Size = new System.Drawing.Size(39, 13);
            this.reddit.TabIndex = 12;
            this.reddit.TabStop = true;
            this.reddit.Text = "reddit";
            this.reddit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reddit_LinkClicked);
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator.LinkColor = System.Drawing.Color.Red;
            this.creator.Location = new System.Drawing.Point(284, 430);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(101, 13);
            this.creator.TabIndex = 15;
            this.creator.TabStop = true;
            this.creator.Text = "by josephwalden";
            this.creator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creator_LinkClicked);
            // 
            // ui
            // 
            this.ui.AutoSize = true;
            this.ui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui.LinkColor = System.Drawing.Color.Red;
            this.ui.Location = new System.Drawing.Point(391, 430);
            this.ui.Name = "ui";
            this.ui.Size = new System.Drawing.Size(81, 13);
            this.ui.TabIndex = 16;
            this.ui.TabStop = true;
            this.ui.Text = "(ui by brnnkr)";
            this.ui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ui_LinkClicked);
            // 
            // debslnk
            // 
            this.debslnk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.debslnk.FlatAppearance.BorderSize = 0;
            this.debslnk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debslnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.debslnk.ForeColor = System.Drawing.Color.DimGray;
            this.debslnk.Location = new System.Drawing.Point(15, 108);
            this.debslnk.Name = "debslnk";
            this.debslnk.Size = new System.Drawing.Size(446, 51);
            this.debslnk.TabIndex = 3;
            this.debslnk.Text = "Get Debs";
            this.debslnk.UseVisualStyleBackColor = false;
            this.debslnk.Click += new System.EventHandler(this.debslnk_Click);
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github.LinkColor = System.Drawing.Color.Red;
            this.github.Location = new System.Drawing.Point(124, 430);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(42, 13);
            this.github.TabIndex = 13;
            this.github.TabStop = true;
            this.github.Text = "github";
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // autolabel
            // 
            this.autolabel.AutoSize = true;
            this.autolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autolabel.ForeColor = System.Drawing.Color.DimGray;
            this.autolabel.Location = new System.Drawing.Point(77, 353);
            this.autolabel.Name = "autolabel";
            this.autolabel.Size = new System.Drawing.Size(312, 25);
            this.autolabel.TabIndex = 19;
            this.autolabel.Text = "automatic respring and uicache";
            this.autolabel.Click += new System.EventHandler(this.autolabel_Click);
            // 
            // paypal
            // 
            this.paypal.AutoSize = true;
            this.paypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypal.LinkColor = System.Drawing.Color.Red;
            this.paypal.Location = new System.Drawing.Point(172, 430);
            this.paypal.Name = "paypal";
            this.paypal.Size = new System.Drawing.Size(44, 13);
            this.paypal.TabIndex = 14;
            this.paypal.TabStop = true;
            this.paypal.Text = "paypal";
            this.paypal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.paypal_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.paypal);
            this.Controls.Add(this.autolabel);
            this.Controls.Add(this.github);
            this.Controls.Add(this.debslnk);
            this.Controls.Add(this.ui);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.reddit);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.version);
            this.Controls.Add(this.error);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.uicache);
            this.Controls.Add(this.respring);
            this.Controls.Add(this.select);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.host);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.install);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Tweak Installer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button respring;
        private System.Windows.Forms.Button uicache;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.LinkLabel error;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.LinkLabel reddit;
        private System.Windows.Forms.LinkLabel creator;
        private System.Windows.Forms.LinkLabel ui;
        private System.Windows.Forms.Button debslnk;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.Label autolabel;
        private System.Windows.Forms.LinkLabel paypal;
    }
}

