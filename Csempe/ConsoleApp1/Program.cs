using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Macska macska = new Macska("Círmos",2.1,"kandúr");
            Console.WriteLine(macska.halad());

            macska.sethangotAd("Meow,Meow,MEOOOWWW");
            Console.WriteLine(macska);
            Console.ReadKey();
        }
    }
}
