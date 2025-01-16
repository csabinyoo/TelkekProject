using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Háromszög : Telek
    {
        private string alak = "Háromszög";
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }
        public double D {  get; set; }
        public double E {  get; set; }

        public Háromszög(string helyrajziSzam, bool kozmu, bool vanSzomszed, double a, double b, double c) : base(helyrajziSzam, kozmu, vanSzomszed)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double TeruletSzamol()
        {
            return Telek.TerületHáromszög(A, B, C);
        }

        public override double KeruletSzamol()
        {
            return Telek.KerületHáromszög(A, B, C);
        }

        public override double KeritesSzamol()
        {
            if (this.vanSzomszed)
            {
                return A + B;
            }
            else
            {
                return KeruletSzamol();
            }
        }

        public override void Info()
        {
            Console.WriteLine("{0}, Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, C: {5}, K: {6:N2} - T: {7} | Kerítés -> {8} m | {9:N0} Ft", alak, kozmu ? "Van" : "Nincs", helyrajziSzam, A, B, C, KeruletSzamol(), TeruletSzamol(), KeritesSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
