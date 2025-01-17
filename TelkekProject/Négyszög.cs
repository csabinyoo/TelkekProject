using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Négyszög : Telek
    {
        private string alak = "Négyszög";
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }
        public double D {  get; set; }
        public double E {  get; set; }

        public Négyszög(string helyrajziSzam, bool kozmu, bool vanSzomszed, double a, double b, double c, double d, double e) : base(helyrajziSzam, kozmu, vanSzomszed)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override double TeruletSzamol()
        {
            return Telek.TerületNégyszög(A, B, C, D, E);
        }

        public override double KeruletSzamol()
        {
            return Telek.KerületNégyszög(A, B, C, D);
        }

        public override double KeritesSzamol()
        {
            return this.vanSzomszed ? A + B + D : A + B + C + D;
        }

        public override void Info()
        {
            Console.WriteLine("{0} -> Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, C: {5}, D: {6}, E: {7}, K: {8:N2} - T: {9} | Kerítés -> {10} m | {11:N0} Ft", alak, kozmu ? "Van" : "Nincs", helyrajziSzam, A, B, C, D, E, KeruletSzamol(), TeruletSzamol(), KeritesSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
