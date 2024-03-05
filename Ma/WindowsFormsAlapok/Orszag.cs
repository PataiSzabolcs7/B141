using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAlapok
{
    internal class Orszag
    {
        string orszagnev;
        double terulet;

        public Orszag(string line)
        {
            string[] sor = line.Split(';');
            OrszagNev = sor[0];
            terulet = double.Parse(sor[1].Replace('.',','));
        }
        public string OrszagNev { get => orszagnev; set => orszagnev = value; }
        public double Terulet { get => terulet; set => terulet = value; }
        public override string ToString()
        {
            return orszagnev;
        }
    }
}
