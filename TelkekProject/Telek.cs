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

        public abstract double Info();

        public abstract double KeruletSzamol();

        public abstract double TeruletSzamol();

        public double NégyzetméterÁrSzámol()
        {
            double arPerNm = Kozmu ? 30000 : 10000;
            return TeruletSzamol() * arPerNm;
        }
    }
}
