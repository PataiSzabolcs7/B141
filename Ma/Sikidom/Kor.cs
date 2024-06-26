﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Kor : Sikidom, IAtmeretez, IRajzolas
    {
       public double sugar;
        double atmero;
        public Kor(double sugar) : base("kör")
        {
            this.sugar = sugar;
            this.atmero = 2 * sugar;
        }
        public double Sugar { get => sugar; }
        public double Atmero { get => atmero; }
        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public void Kisebb()
        {
            Console.WriteLine("Kisebb");
        }

        public void Nagyobb()
        {
            Console.WriteLine("Nagyobb");
        }

        public override double Terulet()
        {
            return sugar * sugar *Math.PI;
        }

        public void Vonalvastag()
        {
            Console.WriteLine("Vastag");
        }

        public void Vonalvekony()
        {
            Console.WriteLine("Vékony");
        }
    }
}
