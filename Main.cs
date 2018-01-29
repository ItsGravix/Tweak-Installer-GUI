using Bunifu.Framework.UI;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweak_Installer.Controls;
using Tweak_Installer.Core;

namespace Tweak_Installer {
    public partial class Main : Form {
        #region Ignore This
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public static Main main;

        public static string version = "1.0";

        static bool resetSearchCount = false;
        static string lastSearch = "";
        const string userAgent = "User-Agent: cydia-api-node/0.1.0";
        static string CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);

        static string LastRootPassword = null;

        static bool searchTweakHint = true;
        static bool rootPassHint = true;

        public Main() {
            InitializeComponent();

            main = this;
            //linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            DoubleBuffered = true;
            searchTweak.Hide();
            bunifuImageButton3.Hide();

            // Check For Updates
            string latestVersion = WebAPI.GetWeb("http://gravitycube.us/tweakinstaller/version.txt");
            Console.WriteLine(version + " " + latestVersion);
            if (version.ToString() != latestVersion) {
                MessageBox.Show("New Version Available! Download at http://gravitycube.us/tweakinstaller/");
                Process.Start("http://gravitycube.us/tweakinstaller/");
                Process.GetCurrentProcess().Kill();
            }
        }

        private string sendJS(string JScript) {
            object[] args = { JScript };
            try {
                return null;//webBrowser1.Document.InvokeScript("eval", args).ToString();
            } catch (Exception) {
                return null;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void Main_Load(object sender, EventArgs e) {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            Connect();
        }

        public void Connect() {
            StartLoading("Connecting...");
            Base.Connect(ipAddress.Text, "root", rootPassword.Text);

            panel3.Show();
            searchTweak.Show();
            installFromFile.Show();
            uninstallFromFile.Show();
            bunifuImageButton3.Show();
            checkConnection.Start();
            StopLoading();
            bunifuiOSSwitch1.Focus();
        }

        public static void StartLoading(string text) {
            if (main.InvokeRequired) {
                main.BeginInvoke((MethodInvoker)delegate { StartLoading(text); });
                return;
            }

            main.loadLabel.Text = text;
            main.pictureBox1.Show();
        }

        public void SecondLoadLabel(string text) {
            if (main.InvokeRequired) {
                main.BeginInvoke((MethodInvoker)delegate { SecondLoadLabel(text); });
                return;
            }

            bunifuCustomLabel4.Show();
            bunifuCustomLabel4.Text = text;
        }

        public static void StopLoading() {
            if (main.InvokeRequired) {
                main.BeginInvoke((MethodInvoker)delegate { StopLoading(); });
                return;
            }

            main.loadLabel.Text = "";
            main.bunifuCustomLabel4.Text = "";
            main.pictureBox1.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e) {
            Base.install(@"C:\Users\origi\Downloads\com.booleanmagic.wicarrier_1.1.4_iphoneos-arm.deb");
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e) {
            if (searchTweak.text == "")
                return;
            resetSearchCount = true;
            bunifuCustomLabel4.Text = "Searching...";
            StartLoading("Searching for Tweaks...");
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        public void AddCard(Package package) {
            if (InvokeRequired) {
                BeginInvoke((MethodInvoker)delegate { AddCard(package); });
                return;
            }

            // Create Card
            PackageCard card = new PackageCard(package);

            int packageCards = 0;
            int combinedHeight = 0;
            int firstX = 0;
            foreach (Control control in panel3.Controls) {
                if (control is PackageCard) {
                    if (packageCards == 0)
                        firstX = control.Location.X;
                    packageCards++;
                    combinedHeight += control.Height;
                }
            }

            Console.WriteLine(packageCards == 0 ? combinedHeight : combinedHeight + 40);
            panel3.Controls.Add(card);

            card.Location = new Point(firstX, packageCards == 0 ? combinedHeight : combinedHeight);
            if (packageCards == 0)
                CenterHorizontally(card, packageCards == 0 ? 0 : SystemInformation.VerticalScrollBarWidth, 0);
        }

        public void CenterHorizontally(Control control, int add, int subtract) {
            Rectangle parentRect = control.Parent.ClientRectangle;
            control.Left = (parentRect.Width - control.Width + add - subtract) / 2;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) {

        }

        private void search_Tick(object sender, EventArgs e) { 
            if (searchTweak.text == "Search For Tweaks (recommended)")
                return;
            if (searchTweak.text == lastSearch)
                return;
            if (resetSearchCount) {
                resetSearchCount = false;
                return;
            }

            StartLoading("Loading Results...");
            SecondLoadLabel("Loading Results...");

            lastSearch = searchTweak.text;
            panel3.Controls.Clear();
            List<Package> results = WebAPI.Search(searchTweak.text);

            new Thread(p => {
                foreach (Package package in results) {
                    AddCard(package);
                }

                foreach (Control control in panel3.Controls) {
                    if (control is PackageCard) {
                        control.Show();
                    }
                }

                StopLoading();
            }).Start();
        }

        private void checkConnection_Tick(object sender, EventArgs e) {
            if (!Base.Connected()) {
                MessageBox.Show("Disconnected from iDevice!", "FATAL ERROR");
                Process.GetCurrentProcess().Kill();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e) {
            Process.GetCurrentProcess().Kill();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e) {
            Base.respring_override = !bunifuiOSSwitch1.Value;
            Base.uicache_override = !bunifuiOSSwitch1.Value;
        }

        private void searchTweak_Enter(object sender, EventArgs e) {
            if (searchTweakHint) {
                searchTweak.text = "";
                searchTweakHint = false;
            }
        }

        private void searchTweak_Leave(object sender, EventArgs e) {
            if (searchTweak.Text == "") {
                searchTweak.text = "Search For Tweaks (recommended)";
                searchTweakHint = true;
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e) {
            panel3.Focus();
        }

        private void Main_MouseClick(object sender, MouseEventArgs e) {
            panel3.Focus();
        }

        private void rootPassword_OnValueChanged(object sender, EventArgs e) {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                LastRootPassword = rootPassword.Text;
            }
        }

        private void rootPassword_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                rootPassword.Text = LastRootPassword;
                Connect();
            }
        }

        private void rootPassword_Enter(object sender, EventArgs e) {
            if (rootPassHint) {
                rootPassword.Text = "";
                rootPassword.PasswordChar = '*';
                rootPassHint = false;
            }
        }

        private void rootPassword_Leave(object sender, EventArgs e) {
            if (rootPassword.Text == "") {
                rootPassword.PasswordChar = '\0';
                rootPassword.Text = "Root Password";
                rootPassHint = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            MessageBox.Show("UI Made by Gravix" + Environment.NewLine + "Base code by josephwalden13" + Environment.NewLine + "Tweak searching & downloading by S0N1C (s0n1c.org/cydia/)" +Environment.NewLine+Environment.NewLine+ "https://github.com/josephwalden13/tweak-installer/", "Credits");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e) {
            StartLoading("Waiting...");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Deb Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "deb";
            openFileDialog1.Filter = "Deb files (*.deb)|*.deb|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StartLoading("Installing " + Path.GetFileName(openFileDialog1.FileName) + "...");
                string downloadsDir = Path.Combine(CurrentDirectory, "downloads");
                if (!Directory.Exists(downloadsDir))
                    Directory.CreateDirectory(downloadsDir);
                string fileName = Path.Combine(downloadsDir, Path.GetFileName(openFileDialog1.FileName));

                if (File.Exists(fileName))
                    File.Delete(fileName);
                File.Copy(openFileDialog1.FileName, fileName);

                Base.install(fileName);

                MessageBox.Show(Path.GetFileName(openFileDialog1.FileName) + " has been installed successfully!", "Tweak Installer");
                StopLoading();
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Deb Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "deb";
            openFileDialog1.Filter = "Deb files (*.deb)|*.deb|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StartLoading("Uninstalling " + Path.GetFileName(openFileDialog1.FileName) + "...");

                string downloadsDir = Path.Combine(CurrentDirectory, "downloads");
                if (!Directory.Exists(downloadsDir))
                    Directory.CreateDirectory(downloadsDir);
                string fileName = Path.Combine(downloadsDir, Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".deb");

                if (File.Exists(fileName))
                    File.Delete(fileName);
                File.Copy(openFileDialog1.FileName, fileName);

                // Uninstall
                if (!Base.uninstall(Path.GetFileNameWithoutExtension(openFileDialog1.FileName))) {
                    MessageBox.Show("Couldn't uninstall " + Path.GetFileName(openFileDialog1.FileName) + "! " + Environment.NewLine + "Please try installing it with this program first.", "Tweak Installer");
                    return;
                }

                MessageBox.Show(Path.GetFileName(openFileDialog1.FileName) + " has been uninstalled successfully!", "Tweak Installer");
            }
        }

        private void bunifuThinButton22_Click_2(object sender, EventArgs e) {
            Process.Start("https://docs.google.com/spreadsheets/d/1YptWW_bBdEQ9naYAfiZ2Aj4H93Y56I4xSYI29u4q_-Y/htmlview?usp=sharing&sle=true");
        }
    }


    public class MyLabel : Label {
        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.DrawString("A", Font, new SolidBrush(ForeColor), 10, 10);
            e.Graphics.DrawString("B", new Font(Font.FontFamily, 20), new SolidBrush(ForeColor), 50, 10);
        }
    }
}
