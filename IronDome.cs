using attackServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class IronDome
    {
        public async void Interception(Missile missile)
        {
            await Task.Delay(10000);
            var random = new Random();
            var list = new List<string> { $"The missile {missile.name} will be intercepted successfully", $"Missile {missile.name} intercept failed" };
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }

    }
}
