using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Department
    {
        public Department(int age)
        {
            this.age = age;

        }

        public int age { get; set; }
        public List<string> names { get; set; }

        public override string ToString()
        {
            return $"Department: {this.age} , {string.Join(", ", this.names)}";
        }
    }
}