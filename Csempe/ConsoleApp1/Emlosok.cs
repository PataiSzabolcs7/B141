using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Emlosok
    {
        public string nev;
        public string faj;
        public int labszam;
        public double suly;
        public string nem;
        string hang;

        public Emlosok(string nev,string faj, int labszam, double suly, string nem, string hang)
        {
            this.nev = nev;
            this.faj = faj;
            this.labszam = labszam;
            this.suly = suly;
            this.nem = nem;
            this.hang = hang;
        }

        public String gethangotAd()
        {
            return hang;
        }
        public void sethangotAd(string hang)
        {
            this.hang = hang;
        }
        public String halad()
        {
            return "előre";
        }
        public override string ToString()
        {
            return this.nev;
           
        }
    }
}
