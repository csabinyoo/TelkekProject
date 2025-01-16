﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    internal class Háromszög : Telek
    {
        private string Alak = "Háromszög";
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }
        public double D {  get; set; }
        public double E {  get; set; }

        public Háromszög(string helyrajziSzam, bool kozmu, double a, double b, double c) : base(helyrajziSzam, kozmu)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double TeruletSzamol()
        {
            return HáromszögSzámítások.Terület(A, B, C);
        }

        public override double KeruletSzamol()
        {
            return HáromszögSzámítások.Kerület(A, B, C);
        }

        public override void Info()
        {
            Console.WriteLine("{0}, Közmű: {1}, Helyrajzi szám: {2}, A: {3}, B: {4}, C: {5}, K: {6:N2} - T: {7} | {8:N0} Ft", Alak, Kozmu ? "Van" : "Nincs", HelyrajziSzam, A, B, C, KeruletSzamol(), TeruletSzamol(), NégyzetméterÁrSzámol());
        }
    }
}
