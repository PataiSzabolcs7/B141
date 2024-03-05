using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Teglalap : Sikidom
    {
        readonly double oldalA;
        readonly double oldalB;
        public Teglalap(double oldalA, double oldalB) : base("téglalap")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
        }
        public double OldalA => oldalA;
        public double OldalB => oldalB;
        public override double Kerulet()
        {
            return (oldalA + oldalB) * 2;
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
