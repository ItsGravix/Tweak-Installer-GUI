using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweak_Installer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnsureBrowserEmulationEnabled();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void EnsureBrowserEmulationEnabled(string exename = "Tweak Installer.exe", bool uninstall = false) {
            try {
                using (
                    var rk = Registry.CurrentUser.OpenSubKey(
                            @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true)
                ) {
                    rk.DeleteValue(exename);
                    if (!uninstall) {
                        dynamic value = rk.GetValue(exename);
                        if (value == null)
                            rk.SetValue(exename, (uint)11000, RegistryValueKind.DWord);
                    } else
                        rk.DeleteValue(exename);
                }
            } catch {
            }
        }
    }
}
