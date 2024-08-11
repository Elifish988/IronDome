using attackServer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using WebSocketSharp;
using WebSocketSharp.Server;


    namespace attackServer
{
        public class MissileHandler : WebSocketBehavior
        {
        //יצירת תור של טילים
        //public static Queue<Missile> missiles = new Queue<Missile>();
        IronDomeMeneger ironDomeMeneger = new IronDomeMeneger();


        private readonly WebSocketServer _wss;
            public MissileHandler(WebSocketServer wss)
            {
                _wss = wss;
            }
        
        //קבלת טיל והכנסה למופע ולתור
        protected override void OnMessage(MessageEventArgs e)
            {
            Missile missile = JsonSerializer.Deserialize<Missile>(e.Data);
            ironDomeMeneger.Enqueue(missile);
         


            //missiles.Enqueue(missile);

            

            //בדיקה להכנסה למיסל
            Console.WriteLine($"Name: {missile.name}");

            //בדיקת שליחת json
            Console.WriteLine("data got is: " + e.Data);

            //בדיקת הכנסה למחסנית
            ironDomeMeneger.Peek();
        }




        



    }
}