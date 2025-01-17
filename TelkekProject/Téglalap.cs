using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Téglalap : Telek
    {
        private string alak = "Téglalap";
        public double A {  get; set; }
        public double B {  get; set; }

        public Téglalap(string helyrajziSzam, bool kozmu, bool vanSzomszed, double a, double b) : base(helyrajziSzam, kozmu, vanSzomszed)
        {
            A = a;
            B = b;
        }

        public override double TeruletSzamol()
        {
            return Telek.TerületTéglalap(A, B);
        }

        public override double KeruletSzamol()
        {
            return Telek.KerületTéglalap(A, B);
        }

        public override double KeritesSzamol()
        {
            return this.vanSzomszed ? A + 2 * B : 2 * (A + B);
        }

        public override void Info()
        {
            Console.WriteLine("{0} -> Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, K: {5:N2} - T: {6} | Kerítés -> {7} m |{8:N0} Ft", alak, kozmu ? "Van" : "Nincs", helyrajziSzam, A, B, KeruletSzamol(), TeruletSzamol(), KeritesSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
