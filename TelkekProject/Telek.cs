using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    abstract internal class Telek
    {
        public string HelyrajziSzam {  get; set; }
        public bool Kozmu { get; set; }

        public Telek(string helyrajziSzam, bool kozmu)
        {
            HelyrajziSzam = helyrajziSzam;
            Kozmu = kozmu;
        }

        internal static class HáromszögSzámítások
        {
            public static double Terület(double a, double b, double c)
            {
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            public static double Kerület(double a, double b, double c)
            {
                return a + b + c;
            }
        }

        internal static class TéglalapSzámítások
        {
            public static double Terület(double a, double b)
            {
                return a * b;
            }

            public static double Kerület(double a, double b)
            {
                return 2 * (a + b);
            }
        }

        internal static class NégyszögSzámítások
        {
            public static double Terület(double a, double b, double c, double d, double e)
            {
                double s1 = (a + b + e) / 2;
                double s2 = (c + d + e) / 2;
                double terulet1 = Math.Sqrt(s1 * (s1 - a) * (s1 - b) * (s1 - e));
                double terulet2 = Math.Sqrt(s2 * (s2 - c) * (s2 - d) * (s2 - e));
                return terulet1 + terulet2;
            }

            public static double Kerület(double a, double b, double c, double d)
            {
                return a + b + c + d;
            }
        }

        public double NégyzetméterÁrSzámol()
        {
            double arPerNm = Kozmu ? 30000 : 10000;
            return TeruletSzamol() * arPerNm;
        }

        public abstract double KeruletSzamol();

        public abstract double TeruletSzamol();

        public abstract void Info();
    }
}
