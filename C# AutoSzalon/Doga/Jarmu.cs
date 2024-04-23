using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Jarmu
    {
        public string Gyarto { get; set; }
        public string Modell {  get; set; }
        public int Evjarat { get; set; }
        public int Alapar {  get; set; }

        public int KilometeroraAllas {  get; set; }

        public Jarmu(string gyarto,string modell,int evjarat, int alapar, int kilometeroraAllas)
        {
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            Alapar = alapar;
            KilometeroraAllas = kilometeroraAllas;
        }

        public void JarmuInfo()
        {
            Console.WriteLine($"{Gyarto} {Modell} {Evjarat} {Alapar} {KilometeroraAllas}");
        }

        public void ArKalkulacio()
        {
            int aktualisEv = DateTime.Now.Year;
            int kor = aktualisEv - Evjarat;
            if (kor > 10)
            {
                Alapar -= 50000;
                Console.WriteLine($"{Alapar} ft-ra csökkent a kora miatt.");
            }
        }

        public void KmAllasFrissites(int km)
        {
            KilometeroraAllas += km;
            Console.Write($"Az auto adatai frissített kilométer állással: ");
            JarmuInfo();
        }
    }
}
