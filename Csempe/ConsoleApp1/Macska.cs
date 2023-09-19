using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Macska : Emlosok
    {
        public Macska( string nev, double suly, string nem) : base(nev, "Macska", 4, suly, nem, "Meoow")
        {
        }
    }
}
