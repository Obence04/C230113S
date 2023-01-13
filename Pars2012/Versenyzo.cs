using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public char Csoport { get; set; }
        public string NemzetEsKod { get; set; }
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public Versenyzo(string[] s)
        {
            Nev = s[0];
            Csoport = s[1][0];
            NemzetEsKod = s[2];
            D1 = s[3] == "X" ? -1 : s[3] == "-" ? -2 : double.Parse(s[3]);
            D2 = s[4] == "X" ? -1 : s[4] == "-" ? -2 : double.Parse(s[4]);
            D3 = s[5] == "X" ? -1 : s[5] == "-" ? -2 : double.Parse(s[5]);
        }

        public double Eredmeny()
        {
            double vissza = 0;
            if (D1 > D2) vissza = D1;
            if (D2 > D3) vissza = D2;
            if (D3 > D2 && D3 > D1) vissza = D3;
            return vissza;
        }
        public string Nemzet
        {
            get
            {
                return NemzetEsKod.Split('(')[0].Trim();
            }
        }
        public string Kod
        {
            get
            {
                return NemzetEsKod.Split('(')[1].Trim(')');
            }
        }
    }
}
