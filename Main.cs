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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweak_Installer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            var f = openFileDialog.ShowDialog();
            switch (f)
            {
                case DialogResult.OK:
                    {
                        deb.Text = openFileDialog.FileName;
                        break;
                    }
            }
        }

        private void install_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "install \"" + deb.Text + "\"");
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "uninstall \"" + deb.Text + "\"");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("settings"); //get ssh settings
            for (int i = 0; i != data.Length; i++)
            {
                data[i] = data[i].Split('#')[0];
            }
            host.Text = data[0];
            username.Text = data[1];
            pass.Text = data[2];
        }

        private void host_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, username.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, username.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, username.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }
    }
}
