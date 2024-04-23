using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoSzalon autoSzalon = new AutoSzalon();
            Jarmu elsoJarmu = new Jarmu("Ford","Focus",2015,5000000,90000);
            Jarmu masodikJarmu = new Jarmu("Subaru", "impreza", 2010, 10000000, 110000);
            autoSzalon.UjJarmuHozzaadasa(elsoJarmu);
            autoSzalon.UjJarmuHozzaadasa(masodikJarmu);
            elsoJarmu.ArKalkulacio();
            masodikJarmu.ArKalkulacio();
            elsoJarmu.KmAllasFrissites(10);
            masodikJarmu.KmAllasFrissites(150);
            autoSzalon.JarmuKeresese("Subaru", "impreza");
            autoSzalon.JarmuEladasa("Subaru", "impreza");
            Terepjaro terepjaro = new Terepjaro("Jeep", "Compass", 2009, 4000000, 135000, "4x4", 10000);
            terepjaro.OffroadCsomagFelszerel();
            terepjaro.VontatóképessegBeallitasa(1500);
            Szemelyauto szemelyauto = new Szemelyauto("Toyota","Corolla",2012,3500000,83000,5,6.5);
            szemelyauto.KenyelmiExtraBeszerzese("klíma");
            szemelyauto.SzinFrissites("Zöld");



        }
    }
}
