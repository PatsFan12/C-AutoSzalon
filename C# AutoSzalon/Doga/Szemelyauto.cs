using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Szemelyauto : Jarmu
    {
        public int UlesekSzama {  get; set; }
        public double Fogyasztas {  get; set; }

        public string Szin {get; set; }

        public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas, int ulesekSzama, double fogyasztas) : base( gyarto, modell, evjarat, alapar, kilometeroraAllas) 
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
            Szin = "fehér";
        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            if (extra == "klíma")
                Alapar += 10000;
            else
                Alapar += 5000;
            Console.Write("Az extra beszerzese utana a jarmu adatai: ");
            base.JarmuInfo();
        }

        public void SzinFrissites(string ujSzin)
        {
            Szin = ujSzin;
            Console.WriteLine($"A szin valtoztatas utan a jarmű adatai: {Gyarto} {Modell} {Evjarat} {Alapar} {KilometeroraAllas} {UlesekSzama} {Fogyasztas} {Szin}");
        }
    }
}
