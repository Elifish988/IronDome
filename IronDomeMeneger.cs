using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{

    internal class IronDomeMeneger: Queue<Missile>
    {
        //יצירת מופע של כיפת ברזל
        IronDome IronDome = new IronDome();
        public IronDomeMeneger() { }
        static IronDomeMeneger missiles = new IronDomeMeneger();
        Dictionary<string, int> dicDamage = new Dictionary<string, int>() {
            { "Qassam", 300 } ,
            { "Fajr-3", 412 } ,
            { "Uragan", 35 } ,
            { "Fajr-5", 320 },
            { "Khibar-1", 400 },
            {"Zilzal-2", 500}};
        public void Enqueue(Missile missile)
        {
            missile.damage = dicDamage[missile.name];
            base.Enqueue(missile);
            //interception();


        }

        //public void interception()
        //{
        //    while (missiles != null)
        //    {
        //        IronDome.Interception(missiles.Dequeue());
        //    }
        //}




        //בדיקה
        public void Peek()
        {
            Missile a = base.Peek();
            Console.WriteLine(a.name);
            Console.WriteLine(a.damage);
            base.Dequeue();

        }

    }
}
