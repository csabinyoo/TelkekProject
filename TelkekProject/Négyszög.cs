using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Négyszög : Telek
    {
        private string Alak = "Négyszög";
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }
        public double D {  get; set; }
        public double E {  get; set; }

        public Négyszög(string helyrajziSzam, bool kozmu, double a, double b, double c, double d, double e) : base(helyrajziSzam, kozmu)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override double TeruletSzamol()
        {
            double s1 = (A + B + E) / 2;
            double s2 = (C + D + E) / 2;
            double terulet1 = Math.Sqrt(s1 * (s1 - A) * (s1 - B) * (s1 - E));
            double terulet2 = Math.Sqrt(s2 * (s2 - C) * (s2 - D) * (s2 - E));
            return terulet1 + terulet2;
        }

        public override double KeruletSzamol()
        {
            return A + B + C + D;
        }

        public override void Info()
        {
            Console.WriteLine("{0} -> Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, C: {5}, D: {6}, E: {7}, K: {8:N2} - T: {9:N2} | {10:N0} Ft", Alak, Kozmu ? "Van" : "Nincs", HelyrajziSzam, A, B, C, D, E, KeruletSzamol(), TeruletSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
