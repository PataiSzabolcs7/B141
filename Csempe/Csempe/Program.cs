using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csempe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a szoba szélességét: ");
            double szel = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a szoba hosszúságát: ");
            double hossz = double.Parse(Console.ReadLine());
            double alap = szel*hossz;
            double hosszufal = hossz*1.5;
            double rovidfal = szel * 1.5;
            double vegeredmeny = (alap + (2 * (hosszufal + rovidfal))) * 1.1 / 1.44;
            Console.WriteLine("Az eredmény:{0}",Math.Round(vegeredmeny ));
            Console.ReadKey();
        }   
    }
}
