using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Téglalap : Telek
    {
        private string Alak = "Téglalap";
        public double A {  get; set; }
        public double B {  get; set; }

        public Téglalap(string helyrajziSzam, bool kozmu, double a, double b) : base(helyrajziSzam, kozmu)
        {
            A = a;
            B = b;
        }

        public override double TeruletSzamol()
        {
            return TéglalapSzámítások.Terület(A, B);
        }

        public override double KeruletSzamol()
        {
            return TéglalapSzámítások.Kerület(A, B);
        }

        public override void Info()
        {
            Console.WriteLine("{0} -> Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, K: {5:N2} - T: {6} | {7:N0} Ft", Alak, Kozmu ? "Van" : "Nincs", HelyrajziSzam, A, B, KeruletSzamol(), TeruletSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
