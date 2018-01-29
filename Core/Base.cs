using jLib;
using SevenZipExtractor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using WinSCP;

namespace Tweak_Installer {
    class Base {
        static Session session = new Session();
        static string CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        public static bool convert = false, jtool = false, uicache = false, respring_override = false, uicache_override = false;

        static string convert_path(string i) {
            return i.Replace("\\", "/").Replace(" ", "\\ ").Replace("(", "\\(").Replace(")", "\\)").Replace("'", "\\'").Replace("@", "\\@");
        }

        static void finish(Session session) {
            if (uicache && !uicache_override) {
                Console.WriteLine("Running uicache (may take up to 30 seconds)");
                session.ExecuteCommand("uicache"); //respring
            }
            if (!respring_override) {
                Console.WriteLine("Respringing...");
                session.ExecuteCommand("killall -9 SpringBoard"); //respring
            }
        }

        static void createDirIfDoesntExist(string path) {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        static void deleteIfExists(string path) {
            if (File.Exists(path)) File.Delete(path);
        }

        static void emptyDir(string path) {
            if (Directory.Exists(path)) Directory.Delete(path, true);
            Directory.CreateDirectory(path);
        }

        static void moveDirIfPresent(string source, string dest, string parent = null) {
            if (Directory.Exists(source)) {
                if (parent != null) {
                    Directory.CreateDirectory(parent);
                }
                Directory.Move(source, dest);
            }
        }

        public static void install(string deb) {
            string debWithoutExtension = Path.GetFileNameWithoutExtension(deb);

            if (deb.Contains(".deb")) {
                emptyDir("temp");


                Console.WriteLine("Extracting " + deb);
                using (ArchiveFile archiveFile = new ArchiveFile(deb)) {
                    archiveFile.Extract("temp");

                }
                Console.WriteLine("e " + Path.Combine(CurrentDirectory, "temp", "data.tar." + (File.Exists("temp\\data.tar.lzma") ? "lzma" : "gz")) + " -o.");

                var p = Process.Start(@"7z.exe", "e \"" + Path.Combine(CurrentDirectory, "temp", "data.tar." + (File.Exists("temp\\data.tar.lzma") ? "lzma" : "gz")) + "\" -o.");
                p.WaitForExit();

                using (ArchiveFile archiveFile = new ArchiveFile("data.tar")) {
                    archiveFile.Extract("files");
                }
            } else if (deb.Contains(".ipa")) {
                emptyDir("temp");
                Console.WriteLine("Extracting IPA " + deb);
                try {
                    using (ArchiveFile archiveFile = new ArchiveFile(deb)) {
                        archiveFile.Extract("temp");
                    }
                    createDirIfDoesntExist("files\\Applications");
                    foreach (string app in Directory.GetDirectories("temp\\Payload\\")) {
                        Directory.Move(app, "files\\Applications\\" + new DirectoryInfo(app).Name);
                    }
                } catch (Exception e) {
                    Console.WriteLine("Not a valid IPA / Write Access Denied");
                    throw e;
                }
            } else {
                emptyDir("temp");
                Console.WriteLine("Extracting Zip " + deb);
                try {
                    using (ArchiveFile archiveFile = new ArchiveFile(deb)) {
                        archiveFile.Extract("temp");
                    }
                } catch (Exception e) {
                    Console.WriteLine("Not a valid ZIP archive / Write Access Denied");
                    throw e;
                }
                if (Directory.Exists("temp\\bootstrap\\")) {
                    Console.WriteLine("Found bootstrap");
                    if (Directory.Exists("temp\\bootstrap\\Library\\SBInject\\")) {
                        createDirIfDoesntExist("files\\usr\\lib\\SBInject");
                        foreach (string file in Directory.GetFiles("temp\\bootstrap\\Library\\SBInject\\")) {
                            File.Move(file, "files\\usr\\lib\\SBInject\\" + new FileInfo(file).Name);
                        }
                        foreach (string file in Directory.GetDirectories("temp\\bootstrap\\Library\\SBInject\\")) {
                            Directory.Move(file, "files\\usr\\lib\\SBInject\\" + new DirectoryInfo(file).Name);
                        }
                        Directory.Delete("temp\\bootstrap\\Library\\SBInject", true);
                    }
                    moveDirIfPresent("temp\\bootstrap\\Library\\Themes\\", "files\\System\\Library\\Themes\\", "files\\System\\Library\\");
                    foreach (string dir in Directory.GetDirectories("temp")) {
                        FileSystem.MoveDirectory(dir, "files\\" + new DirectoryInfo(dir).Name, true);
                    }
                    foreach (string file in Directory.GetFiles("temp")) {
                        File.Copy(file, "files\\" + new FileInfo(file).Name, true);
                    }
                } else {
                    Console.WriteLine("Unrecognised format. Determining ability to install");
                    List<string> exts = new List<string>();
                    foreach (string i in Directory.GetFiles("temp")) {
                        string ext = new FileInfo(i).Extension;
                        if (!exts.Contains(ext)) exts.Add(ext);
                    }
                    if (exts.Count == 2 && exts.Contains(".dylib") && exts.Contains(".plist")) {
                        Console.WriteLine("Substrate Addon. Installing");
                        createDirIfDoesntExist("files\\usr\\lib\\SBInject");
                        foreach (string i in Directory.GetFiles("temp")) {
                            File.Copy(i, "files\\usr\\lib\\SBInject\\" + new FileInfo(i).Name, true);
                        }
                        moveDirIfPresent("files\\Library\\PreferenceBundles\\", "files\\bootstrap\\Library\\PreferenceBundles\\");
                        moveDirIfPresent("files\\Library\\PreferenceLoader\\", "files\\bootstrap\\Library\\PreferenceLoader\\");
                    } else {
                        Console.WriteLine("Unsafe to install. To install this tweak you must do so manually. Press enter to continue...");
                        Console.ReadLine();
                    }
                }
            }

            // Convert to Electra format
            string name = debWithoutExtension;
            if (convert)
            {
                Console.WriteLine("Converting to electra tweak format");
                createDirIfDoesntExist("files\\bootstrap");
                createDirIfDoesntExist("files\\bootstrap\\Library");
                if (Directory.Exists("files\\Library\\MobileSubstrate\\")) {
                    createDirIfDoesntExist("files\\usr\\lib\\SBInject");
                    foreach (string file in Directory.GetFiles("files\\Library\\MobileSubstrate\\DynamicLibraries\\")) {
                        File.Move(file, "files\\usr\\lib\\SBInject\\" + new FileInfo(file).Name);
                    }
                    foreach (string file in Directory.GetDirectories("files\\Library\\MobileSubstrate\\DynamicLibraries\\")) {
                        Directory.Move(file, "files\\usr\\lib\\SBInject\\" + new DirectoryInfo(file).Name);
                    }
                    Directory.Delete("files\\Library\\MobileSubstrate", true);
                }
                moveDirIfPresent("files\\Library\\Themes\\", "files\\System\\Library\\Themes\\", "files\\System\\Library\\");
                moveDirIfPresent("files\\Library\\PreferenceBundles\\", "files\\bootstrap\\Library\\PreferenceBundles\\");
                moveDirIfPresent("files\\Library\\PreferenceLoader\\", "files\\bootstrap\\Library\\PreferenceLoader\\");
            }

            Crawler c = new Crawler("files", true); // Gets all files in the tweak
            c.Remove("DS_STORE");

            string s = "";
            c.Files.ForEach(i => {
                s += ("rm " + convert_path(i) + "\n"); // Creates uninstall script for tweak (used if uninstall == true)
            });

            if (!Directory.Exists(@"files\TweakUninstallers\"))
                Directory.CreateDirectory(@"files\TweakUninstallers\");

            File.WriteAllText(@"files\TweakUninstallers\" + name + ".sh", s); // Add uninstall script to install folder

            Console.WriteLine("Installing");

            if (Directory.Exists("files\\Applications") && jtool) {
                if (File.Exists("plat.ent"))
                    File.Copy("plat.ent", "files\\plat.ent", true);
            }

            if (Directory.Exists("files\\Applications\\electra.app")) {
                var f = MessageBox.Show("Please do not try this!");
                Process.GetCurrentProcess().Kill();
            }

            foreach (string dir in Directory.GetDirectories("files")) {
                session.PutFiles(dir, "/"); //put directories
            }

            foreach (string file in Directory.GetFiles("files")) {
                session.PutFiles(file, "/"); //put files
            }

            if (Directory.Exists("files\\Applications") && jtool) {
                Console.WriteLine("Signing applications");
                foreach (var app in Directory.GetDirectories("files\\Applications\\")) {
                    c.Files.ForEach(i => {
                        if (i.Contains("\\Applications\\")) {
                            uicache = true;
                            bool sign = false;
                            {
                                if (new FileInfo(i).Name.Split('.').Length < 2) sign = true;
                                if (!sign) {
                                    if (i.Split('.').Last() == "dylib") sign = true;
                                }
                                i = convert_path(i);
                                if (sign) {
                                    session.ExecuteCommand("jtool -e arch -arch arm64 " + i);
                                    session.ExecuteCommand("mv " + i + ".arch_arm64 " + i);
                                    session.ExecuteCommand("jtool --sign --ent /plat.ent --inplace " + i);
                                }
                            }
                        }
                    });
                }
            }

            File.Delete(deb);
            Directory.Delete("temp", true);
            Directory.Delete("files", true);
            Directory.Delete("downloads", true);
            finish(session);
        }

        public static void uninstall(Package package) {
            Console.WriteLine("Uninstalling");
            string shFile = "/TweakUninstallers/" + package.name + "_" + package.version + ".sh";
            session.ExecuteCommand("sh " + shFile);
            if (Directory.Exists("files\\Applications")) {
                uicache = true;
            }
            Console.WriteLine("Locating and removing *some* empty folders");
            session.ExecuteCommand("find /System/Library/Themes/ -type d -empty -delete");
            session.ExecuteCommand("find /usr/ -type d -empty -delete");
            session.ExecuteCommand("find /Applications/ -type d -empty -delete");
            session.ExecuteCommand("find /Library/ -type d -empty -delete");
            session.ExecuteCommand("find /bootstrap/ -type d -empty -delete");
            session.ExecuteCommand("rm -rf " + shFile);
            finish(session);
        }

        public static bool uninstall(string filename) {
            Console.WriteLine("Uninstalling");
            string shFile = "/TweakUninstallers/" + filename + ".sh";

            if (!session.FileExists(shFile))
                return false;

            session.ExecuteCommand("sh " + shFile);
            if (Directory.Exists("files\\Applications")) {
                uicache = true;
            }
            Console.WriteLine("Locating and removing *some* empty folders");
            session.ExecuteCommand("find /System/Library/Themes/ -type d -empty -delete");
            session.ExecuteCommand("find /usr/ -type d -empty -delete");
            session.ExecuteCommand("find /Applications/ -type d -empty -delete");
            session.ExecuteCommand("find /Library/ -type d -empty -delete");
            session.ExecuteCommand("find /bootstrap/ -type d -empty -delete");
            session.ExecuteCommand("rm -rf " + shFile);
            finish(session);
            return true;
        }

        public static bool Connected() {
            try {
                session.ExecuteCommand("cd /");
                return true;
            } catch (Exception) {
                return false;
            }
        }

        public static bool UninstallerExists(Package package) {
            return session.FileExists("/TweakUninstallers/" + package.name + "_" + package.version + ".sh");
        }

        static void noInstall() {
            uicache = true;
            finish(session);
        }

        public static void Connect(string ip, string user, string password) {
            createDirIfDoesntExist(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tweak-installer\\");

            Console.WriteLine("Connecting");

            SessionOptions sessionOptions = new SessionOptions {
                Protocol = Protocol.Sftp,
                HostName = ip,
                UserName = user,
                Password = password,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };

            try {
                session.Open(sessionOptions);
            } catch (SessionRemoteException e) {
                if (e.ToString().Contains("refused")) Console.WriteLine("Error: SSH Connection Refused\nAre you jailbroken?\nHave you entered your devices IP correctly?");
                else if (e.ToString().Contains("Access denied")) Console.WriteLine("Error: SSH Connection Refused due to incorrect credentials. Are you sure you typed your password correctly?");
                else if (e.ToString().Contains("Cannot initialize SFTP protocol")) Console.WriteLine("Error: SFTP not available. Make sure you have sftp installed by default. For Yalu or Meridian, please install \"SCP and SFTP for dropbear\" by coolstar. For LibreIOS, make sure SFTP is moved to /usr/bin/.");
                else {
                    Console.WriteLine("Unknown Error. Please use the big red bug report link and include some form of crash report. Error report copying to clipboard.");
                    Thread.Sleep(2000);
                    Clipboard.SetText(e.ToString());
                    MessageBox.Show("Could not connect to " + ip);
                    //throw e;
                }
            }

            if (session.FileExists("/usr/lib/SBInject")) {
                convert = true;
                if (!session.FileExists("/System/Library/Themes")) {
                    session.CreateDirectory("/System/Library/Themes");
                    session.ExecuteCommand("touch /System/Library/Themes/dont-delete");
                    Console.WriteLine("Themes folder missing. Touching /System/Library/Themes/dont-delete to prevent this in future");
                }
                jtool = true;
            }
            if (session.FileExists("/jb/")) {
                jtool = true;
            }

            emptyDir("files");
            emptyDir("temp");
            deleteIfExists("data.tar");

            Console.WriteLine("DONE");
        }
    }
}
