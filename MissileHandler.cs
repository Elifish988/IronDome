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
        IronDome ironDome = new IronDome();

        private readonly WebSocketServer _wss;
            public MissileHandler(WebSocketServer wss)
            {
                _wss = wss;
            }
        
        //קבלת טיל והכנסה למופע ולתור
        protected override void OnMessage(MessageEventArgs e)
            {
            Missile missile = JsonSerializer.Deserialize<Missile>(e.Data);
            ironDome.Enqueue(missile);

            //missiles.Enqueue(missile);

            

            //בדיקה להכנסה למיסל
            Console.WriteLine($"Name: {missile.name}");

            //בדיקת שליחת json
            Console.WriteLine("data got is: " + e.Data);

            //בדיקת הכנסה למחסנית
            ironDome.Peek();
        }


        



    }
}