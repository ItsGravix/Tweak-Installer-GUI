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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.respring = new System.Windows.Forms.Button();
            this.uicache = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(12, 123);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(96, 23);
            this.install.TabIndex = 0;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // Uninstall
            // 
            this.Uninstall.Location = new System.Drawing.Point(114, 123);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(95, 23);
            this.Uninstall.TabIndex = 1;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = true;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(12, 29);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(197, 20);
            this.host.TabIndex = 2;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 68);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(197, 20);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "device ip address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "root password";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(12, 94);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(197, 23);
            this.select.TabIndex = 10;
            this.select.Text = "Select Debs and IPAs";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "example.deb";
            this.openFileDialog.Multiselect = true;
            // 
            // respring
            // 
            this.respring.Location = new System.Drawing.Point(15, 152);
            this.respring.Name = "respring";
            this.respring.Size = new System.Drawing.Size(96, 23);
            this.respring.TabIndex = 11;
            this.respring.Text = "Respring";
            this.respring.UseVisualStyleBackColor = true;
            this.respring.Click += new System.EventHandler(this.respring_Click);
            // 
            // uicache
            // 
            this.uicache.Location = new System.Drawing.Point(113, 152);
            this.uicache.Name = "uicache";
            this.uicache.Size = new System.Drawing.Size(96, 23);
            this.uicache.TabIndex = 12;
            this.uicache.Text = "Uicache";
            this.uicache.UseVisualStyleBackColor = true;
            this.uicache.Click += new System.EventHandler(this.uicache_Click);
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Checked = true;
            this.auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auto.Location = new System.Drawing.Point(15, 181);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(174, 17);
            this.auto.TabIndex = 13;
            this.auto.Text = "automatic respring and uicache";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(12, 197);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(188, 13);
            this.error.TabIndex = 14;
            this.error.TabStop = true;
            this.error.Text = "report errors / bugs / general problems";
            this.error.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.error_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 219);
            this.Controls.Add(this.error);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.uicache);
            this.Controls.Add(this.respring);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.host);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.install);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button respring;
        private System.Windows.Forms.Button uicache;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.LinkLabel error;
    }
}

