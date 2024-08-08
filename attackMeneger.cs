using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IronDome
{
    internal class AttackMeneger
    {
        public static async Task<string> ReadFileAsync(string filPath)
        {
            string result = await Task.Run(() => File.ReadAllText(filPath));
            return result;
        }

    }
}
