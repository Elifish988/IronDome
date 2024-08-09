using attackServer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using static System.Net.Mime.MediaTypeNames;


namespace attackServer
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            //string filePathToString = "D:\\kodcode\\IronDome\\JasonMissiles.json";
            //string content = await AttackMeneger.ReadFileAsync(filePathToString);
            //List<Missile> missiles = JsonSerializer.Deserialize<List<Missile>>(content);

            //foreach (var missile in missiles)
            //{
            //    Console.WriteLine($"Name: {missile.name}");
            //}
            
            WebSocketServer wss = new WebSocketServer("ws://localhost:3108");
            wss.AddWebSocketService<MissileHandler>("/MissileHandler", () => new MissileHandler(wss));
            wss.Start();
            Console.WriteLine("Backend server is running. Press Enter to exit...");
            Console.ReadLine();
            wss.Stop();

        }

        


    }
}
