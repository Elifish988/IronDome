using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronDome
{
    internal class Missile
    {
        public string name { get; set; }
        public string speed { get; set; }
        public int mass { get; set; }
        public Dictionary<string, int> origin { get; set; }
        public Dictionary<string, int> angle { get; set; }
        public int time { get; set; }
    }
}
