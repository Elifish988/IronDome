using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{

    internal class IronDome: Queue<Missile>
    {
        public IronDome() { }
        static IronDome missiles = new IronDome();
        public void Enqueue(Missile missile)
        {
            base.Enqueue(missile);
        }


        // בדיקה
        public void  Peek()
        {
            Missile a = base.Peek();
            Console.WriteLine(a.name);
            
        }

    }
}
