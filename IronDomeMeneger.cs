using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp.Server;

namespace attackServer
{

    public class IronDomeMeneger: ConcurrentQueue<Missile>
    {
        public  WebSocketServer _wss;

        //יצירת מופע של כיפת ברזל
        IronDome IronDome = new IronDome();

        public IronDomeMeneger() { }
        Dictionary<string, int> dicDamage = new Dictionary<string, int>() {
            { "Qassam", 300 } ,
            { "Fajr-3", 412 } ,
            { "Uragan", 35 } ,
            { "Fajr-5", 320 },
            { "Khibar-1", 400 },
            {"Zilzal-2", 500}};
        public void Enqueue(Missile missile, WebSocketServer wss)
        {
            _wss = wss;
            missile.damage = dicDamage[missile.name];
            base.Enqueue(missile);

        }

        public async void BroadcastStatus(string message)
        {
            _wss.WebSocketServices["/MissileHandler"].Sessions.Broadcast(message);
        }




        //יצירת ארבע כיפות ברזל
        public void Start()
        {
            int ironDomAmount = 4;
            for(int i = 0; i < ironDomAmount; i++)
            {
                var interceptorThred = new Thread(interceptor);
                interceptorThred.Start();
            }
  
        }

        public async void interceptor()
        {
            IronDome ironDome = new IronDome();
            while (true)
            {

                if (this.TryDequeue(out Missile missile))
                {
                    string result = await IronDome.Interception(missile);
                    Console.WriteLine(result);
                    //var jeson = JsonSerializer.Serialize(result);
                    BroadcastStatus(result);


                }
 
            }

        }




    }
}
