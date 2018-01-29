using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweak_Installer {
    public class Package {
        public string display { get; set; }
        public string name { get; set; }
        public string section { get; set; }
        public string summary { get; set; }
        public string version { get; set; }
        public string author { get; set; }
        public string size { get; set; }

        public bool disabled = false;
    }
}
