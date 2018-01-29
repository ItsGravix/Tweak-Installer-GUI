using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tweak_Installer.Core {
    public class WebAPI {
        public static string GetWeb(string URL) {
            System.Net.WebClient wc = new System.Net.WebClient();
            return wc.DownloadString(URL);
        }

        public static List<Package> Search(string text) {
            WebClient client = new WebClient();
            string result = client.DownloadString("http://cydia.saurik.com/api/macciti?query=" + text);

            // Deserialize JSON
            dynamic jsonObject = JsonConvert.DeserializeObject(result);
            JArray results = jsonObject.results;

            List<Package> packages = JsonConvert.DeserializeObject<List<Package>>(results.ToString());

            // Set Author
            foreach (Package package in packages) {
                Console.WriteLine(package.name + " | " + package.display);

                string author = GetAuthor(package.name);
                package.author = author;
                package.size = GetSize(package.name);

                if (package.display == null) {
                    package.disabled = true;
                }
            }

            return packages;
        }

        public static string GetDownload(string package) {
            try {
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString("http://apt.thebigboss.org/onepackage.php?bundleid=" + package);

                // Get Download Link
                string preURl = Regex.Split(html, "Download: <a href=\"")[1];
                string url = Regex.Split(preURl, "\">Deb</a>")[0];
                Console.WriteLine(url);

                return url;
            } catch (Exception) {
                return "Unknown Author";
            }
        }

        public static string GetAuthor(string package) {
            try {
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString("http://cydia.saurik.com/package/" + package);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                return doc.GetElementbyId("contact").InnerText;
            } catch (Exception) {
                return "Unknown Author";
            }
        }

        public static string GetSize(string package) {
            try {
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString("http://cydia.saurik.com/package/" + package);
                //Console.WriteLine(package);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                return doc.GetElementbyId("extra").InnerText;
            } catch (Exception) {
                return "Unknown Size";
            }
        }
    }
}
