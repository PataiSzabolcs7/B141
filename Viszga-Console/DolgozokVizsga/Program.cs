using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozokVizsga
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Dolgozo> dolgozok;

        static void Main(string[] args)
        {
            dolgozok = db.getAllDolgozo();
            feladat01();
            feladat02();
            feladat03();
            feladat04();
            Console.WriteLine("Program Vége");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            Console.WriteLine("*** 4. Feladat! ***");
            foreach (var item in dolgozok.Where(a => a.reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"\t {item.nev} ");
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("*** 3. Feladat! ***");
            foreach (var item in dolgozok.GroupBy(a => a.reszleg).Select(b => new {reszleg = b.Key, letszam = b.Count()}))
            {
                Console.WriteLine($"\t {item.reszleg} : {item.letszam} Fő");
            }
        }

        private static void feladat02()
        {
            Console.WriteLine("*** 2. Feladat! ***");
            int maxBer = dolgozok.Max(a => a.ber);
            Dolgozo dolgozo = dolgozok.Find(a => a.ber == maxBer);
            Console.WriteLine($"\t Legjobban kereső munkás: {dolgozo.nev}");
        }

        private static void feladat01()
        {
            Console.WriteLine("*** 1. Feladat! ***");
            Console.WriteLine($"\t A dolgozók száma : {dolgozok.Count} fő");

        }
    }
}
