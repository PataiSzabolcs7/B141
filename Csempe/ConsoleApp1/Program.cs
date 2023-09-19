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
            List<Emlosok> emlosok = new List<Emlosok>();

            emlosok.Add(new Macska("Círmos",2.1,"kandúr"));
            emlosok.Add(new Kutya("Yoko", 16, "Kan"));
            emlosok.Add(new Macska("Szerénke", 1.3, "nőstény"));
            foreach(var item in emlosok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
