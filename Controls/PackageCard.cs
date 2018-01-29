using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Tweak_Installer.Core;

namespace Tweak_Installer.Controls {
    public partial class PackageCard : UserControl {
        static string CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);

        public Package package;

        public PackageCard(Package package) {
            InitializeComponent();

            this.package = package;

            if (package.display == null)
                download.Enabled = false;

            display.Text = package.display;
            author.Text = "by " + package.author;
            version.Text = "Version: " + package.version;
            size.Text = "Size: " + package.size;
            description.Text = package.summary;

            if (package.section.Contains("Themes")) {
                download.Enabled = false;
            }

            pictureBox1.Load("http://cydia.saurik.com/icon@2x/" + package.name + ".png");

            if (Base.UninstallerExists(package)) {
                download.Location = new Point(61, 372);
                uninstall.Show();
            }
        }

        private void bunifuSeparator4_Load(object sender, EventArgs e) {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e) {

        }

        private void download_Click(object sender, EventArgs e) {
            Main.StartLoading("Installing " + package.name + "...");
            // Download Tweak
            string downloadsDir = Path.Combine(CurrentDirectory, @"downloads");
            string url = WebAPI.GetDownload(package.name);

            if (!Directory.Exists(downloadsDir))
                Directory.CreateDirectory(downloadsDir);

            string fileDir = Path.Combine(downloadsDir, package.name + "_" + package.version + ".deb");
            WebClient Client = new WebClient();
            Client.DownloadFile(url, fileDir);

            // Install Tweak
            Base.install(fileDir);

            MessageBox.Show(package.display + " has been installed successfully!", "Tweak Installer");

            download.Location = new Point(61, 372);
            uninstall.Show();
            Main.StopLoading();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            Main.StartLoading("Uninstalling " + package.name + "...");
            Base.uninstall(package);
            MessageBox.Show(package.display + " has been uninstalled successfully!", "Tweak Installer");

            download.Location = new Point(166, 372);
            uninstall.Hide();
            Main.StopLoading();
        }
    }
}
