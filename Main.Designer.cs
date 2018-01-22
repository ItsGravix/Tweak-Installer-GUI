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
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deb = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(12, 201);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(96, 23);
            this.install.TabIndex = 0;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // Uninstall
            // 
            this.Uninstall.Location = new System.Drawing.Point(114, 201);
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
            this.pass.Location = new System.Drawing.Point(12, 107);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(197, 20);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 68);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(197, 20);
            this.username.TabIndex = 4;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "deb";
            // 
            // deb
            // 
            this.deb.Location = new System.Drawing.Point(12, 146);
            this.deb.Name = "deb";
            this.deb.Size = new System.Drawing.Size(197, 20);
            this.deb.TabIndex = 9;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(12, 172);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(197, 23);
            this.select.TabIndex = 10;
            this.select.Text = "Select Deb";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "example.deb";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 230);
            this.Controls.Add(this.select);
            this.Controls.Add(this.deb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
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
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deb;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

