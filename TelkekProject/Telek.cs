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

       
            public static double TerületNégyszög(double a, double b, double c, double d, double e)
            {
            
               return TerületHáromszög (a, b, e) + TerületHáromszög (c, d ,e);
            }

            public static double KerületNégyszög(double a, double b, double c, double d)
            {
                return a + b + c + d;
            }

        public static double TerületHáromszög(double a, double b, double e)
        {
            double s = (a + b + e) / 2;
           
            double terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - e));
          
            return terulet;
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
