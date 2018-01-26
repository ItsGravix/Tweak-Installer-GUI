//Copyright 2018 josephwalden
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweak_Installer
{
    public partial class Main : Form
    {
        static List<string> debs = new List<string>();
        public Main()
        {
            InitializeComponent();
        }
        string join(List<string> s, string i)
        {
            string temp = "";
            foreach (string j in s)
            {
                temp += '"' + j + '"' + i;
            }
            return temp;
        }
        private void select_Click(object sender, EventArgs e)
        {
            debs.Clear();
            var f = openFileDialog.ShowDialog();
            switch (f)
            {
                case DialogResult.OK:
                    {
                        foreach (string i in openFileDialog.FileNames)
                        {
                            debs.Add(i);
                        }
                        break;
                    }
            }
        }

        private void install_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update " + (!auto.Checked ? "dont-respring dont-refresh " : "") + " install " + join(debs, " "));
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update " + (!auto.Checked ? "dont-respring dont-refresh " : "") + " uninstall " + join(debs, " "));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tweak-installer\\")) Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tweak-installer\\");
            //check for updates
            try
            {
                using (WebClient client = new WebClient())
                {
                    string version = client.DownloadString("https://raw.githubusercontent.com/josephwalden13/tweak-installer/master/bin/Debug/version.txt");
                    string current = File.ReadAllText("version.txt");
                    if (current != version)
                    {
                        var f = MessageBox.Show(caption: "Update Available!", text: ($"Version {version.Replace("\n", "")} released. Please download it from https://github.com/josephwalden13/tweak-installer/releases\nWould you like to update?"), buttons: MessageBoxButtons.YesNo);
                        if (f == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/josephwalden13/tweak-installer/releases");
                        }
                    }
                }
            }
            catch { }
            if (!File.Exists("settings"))
            {
                string[] def = new string[3];
                File.WriteAllLines("settings", def);
            }
            string[] data = File.ReadAllLines("settings"); //get ssh settings
            for (int i = 0; i != data.Length; i++)
            {
                data[i] = data[i].Split('#')[0];
            }
            host.Text = data[0];
            pass.Text = data[2];
        }

        private void host_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, "root", pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, "root", pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void respring_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update no-install dont-refresh");
        }

        private void uicache_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update no-install dont-respring");
        }

        private void error_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/josephwalden13/tweak-installer/issues");
        }

        private void debslnk_Click(object sender, EventArgs e)
        {
            Process.Start("http://s0n1c.org/cydia/");
        }

        private void reddit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/josephwalden/");
        }

        private void creator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/josephwalden/");
        }

        private void ui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/brnnkr/");
        }

        private void twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/jmw_2468");
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/josephwalden13/");
        }

        private void paypal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://paypal.me/JosephWalden");
        }

        private void autolabel_Click(object sender, EventArgs e)
        {
            auto.Checked = !auto.Checked;
        }
    }
}
