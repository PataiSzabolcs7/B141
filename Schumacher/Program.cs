using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Schumacher
{
    internal class Program
    {   
        static List<Scumi> adatok = new List<Scumi>();
        static void Main(string[] args)
        {
            adatokBeolvasas();
            Feladatok3();
            Console.WriteLine("Program Vége!");
            Console.ReadKey();  
        }

        private static void Feladatok3()
        {
            Console.WriteLine( "3.Feladat");
            Console.WriteLine(  $"\t{adatok.Count} sort olvastam be.");
        }

        private static void adatokBeolvasas()
        {
            try
            {

                using (StreamReader file = new StreamReader("schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Scumi(file.ReadLine()));
                        
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
