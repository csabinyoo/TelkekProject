using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProject
{
    abstract internal class Telek
    {
        public string helyrajziSzam {  get; set; }
        public bool kozmu { get; set; }
        public bool vanSzomszed { get; set; }

        public Telek(string helyrajziSzam, bool kozmu, bool vanSzomszed)
        {
            this.helyrajziSzam = helyrajziSzam;
            this.kozmu = kozmu;
            this.vanSzomszed = vanSzomszed;
        }


        public static double TerületTéglalap(double a, double b)
        {
            return a * b;
        }

        public static double KerületTéglalap(double a, double b)
        {
            return 2 * (a + b);
        }


        public static double TerületNégyszög(double a, double b, double c, double d, double e)
         {
            return TerületHáromszög(a, b, e) + TerületHáromszög(c, d ,e);
         }

         public static double KerületNégyszög(double a, double b, double c, double d)
         {
            return KerületHáromszög(a,b,c) + d;
         }

        public static double TerületHáromszög(double a, double b, double e)
        {
            double s = (a + b + e) / 2;
           
            double terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - e));
          
            return terulet;
        }

        public static double KerületHáromszög(double a, double b, double c)
        {
            return a + b + c;
        }

        public double NégyzetméterÁrSzámol()
        {
            double arPerNm = kozmu ? 30000 : 10000;
            return TeruletSzamol() * arPerNm;
        }

        public abstract double KeruletSzamol();

        public abstract double TeruletSzamol();

        public abstract void Info();

        public abstract double KeritesSzamol();
    }
}
