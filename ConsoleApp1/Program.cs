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
            double g;
            int a = szamotker("Add meg az első számot: ");
            int b = szamotker("Add meg a második számot:");
            

                Console.WriteLine("+ --- 1 || - --- 2 || * --- 3 || / --- 4");
                int valasztas = int.Parse(Console.ReadLine());

           

            switch (valasztas)
            {
                case 1:
                    g = a+b;
                    Console.WriteLine(g);
                    break;
                case 2:
                    g = a - b;
                    Console.WriteLine(g);
                    break;
                case 3:
                    g = a * b;
                    Console.WriteLine(g);
                    break;
                case 4:
                    g = a / b;
                    Console.WriteLine(g);
                    break;
                default:
                    Console.WriteLine("Nem jó");
                    break;
            }

            
            Console.ReadKey();
        }

        private static int szamotker(string szoveg)
        {
            int bekertszam;
            Console.Write(szoveg);
            bekertszam = int.Parse(Console.ReadLine());
            return bekertszam;
        }
    }
}
