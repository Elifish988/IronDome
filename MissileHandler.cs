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


        private readonly WebSocketServer _wss;
        private readonly IronDomeMeneger _ironDomeMeneger;
            public MissileHandler(WebSocketServer wss, IronDomeMeneger ironDomeMeneger)
            {
                _wss = wss;
                this._ironDomeMeneger = ironDomeMeneger;
            }
        
        //קבלת טיל והכנסה למופע ולתור
        protected override void OnMessage(MessageEventArgs e)
        {
            Missile missile = JsonSerializer.Deserialize<Missile>(e.Data);
            this._ironDomeMeneger.Enqueue(missile, _wss);
         
            //בדיקה להכנסה למיסל
            Console.WriteLine($"Name: {missile.name}");

            //בדיקת שליחת json
            Console.WriteLine("data got is: " + e.Data);
        }














    }
}