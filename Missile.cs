using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    public class Missile
    {
        public string name { get; set; }
        public string speed { get; set; }
        public int mass { get; set; }
        public Dictionary<string, double> origin { get; set; }
        public Dictionary<string, double> angle { get; set; }
        public int time { get; set; }
    }
}
