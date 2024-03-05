using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Program
    {
       static List<Sikidom> sikidomok = new List<Sikidom>();
        static void Main(string[] args)
        {
            sikidomok.Add(new Kor(5));
            sikidomok.Add(new Kor(4.3));
            sikidomok.Add(new Negyzet(5));
            sikidomok.Add(new Teglalap(3,2));

            foreach (var item in sikidomok)
            {
                if (item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item;
                    Console.WriteLine($"Az 1.Elem {item.Kerulet()} - {item.Terulet()} - {kor.Sugar}");
                    kor.Kisebb();
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"Az 1.Elem {item.Kerulet()} - {item.Terulet()}");
                }
                else if (item.GetType().Equals(typeof(Teglalap)))
                {
                    Teglalap teglalap = (Teglalap)item;
                    Console.WriteLine($"Az 1.Elem {item.Kerulet()} - {item.Terulet()} - {teglalap.OldalA} - {teglalap.OldalB}");
                }
            }


            Console.WriteLine("Program vége");
            Console.ReadLine();
        }
    }
}
