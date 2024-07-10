using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retoxikalo
{
    internal class Ital
    {
        public string ItalNev { get; private set; }
        public int EgysegAr { get; set; }
        public int Mennyiseg { get; private set; }
        public int OsszMennyiseg { get; private set; }
        public string Bevetel { get; private set; }

        public Ital(string italNev, int egysegAr)
        {
            ItalNev = italNev;
            EgysegAr = egysegAr;
        }

        public void Rendel(int db)
        {
            Mennyiseg += db;
        }

        public int Fizetendo()
        {
            return Mennyiseg * EgysegAr;
        }

        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * EgysegAr;
            Mennyiseg = 0;
        }

        public string Arlistaba()
        {
            return $"{ItalNev} ({EgysegAr} Ft)";
        }

        public string Konyvelesbe()
        {
            return $"{ItalNev};{OsszMennyiseg};{Bevetel}";
        }



        public override string ToString()
        {
            return Mennyiseg.ToString().PadLeft(4) + " " + ItalNev.PadRight(35) + Fizetendo().ToString().PadLeft(10) + " Ft";
        }

    }
}