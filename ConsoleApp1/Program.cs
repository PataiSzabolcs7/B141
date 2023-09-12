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
            bool g = false;
            Console.WriteLine("Add meg az első számot");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot");
            int b = int.Parse(Console.ReadLine());
            

                Console.WriteLine("+ --- 1 || - --- 2 || * --- 3 || / --- 4");
                int valasztas = int.Parse(Console.ReadLine());

           

            switch (valasztas)
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a*b);
                    break;
                case 4:
                    Console.WriteLine(a/b);
                    break;
                default:
                    Console.WriteLine("Nem jó");
                    break;
            }

            
            Console.ReadKey();
        }
    }
}
