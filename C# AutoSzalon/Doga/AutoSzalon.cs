using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class AutoSzalon
    {
        public List<Jarmu> jarmuvekLista { get; set; }

        public AutoSzalon()
        {
            jarmuvekLista = new List<Jarmu>();
        }

        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            jarmuvekLista.Add(jarmu);
            Console.Write("Sikeresen hozzaadva a listahoz: ");
            jarmu.JarmuInfo();
        }

        public bool JarmuEladasa(string gyarto, string modell)
        {
            foreach (Jarmu item in jarmuvekLista)
            {
                if (item.Gyarto == gyarto && item.Modell == modell)
                {
                    Console.WriteLine($"{item.Gyarto} {item.Modell} {item.Evjarat} {item.Alapar} {item.KilometeroraAllas} sikeresen eltávolítva a listából.");
                    jarmuvekLista.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public Jarmu JarmuKeresese(string gyarto, string modell)
        {
            foreach (Jarmu item in jarmuvekLista)
            {
                if (item.Gyarto == gyarto && item.Modell == modell)
                {
                    item.JarmuInfo();
                    return item;
                }
            }
            return null;
        }
        public void JarmuvekListazasa()
        {
            foreach (var item in jarmuvekLista)
            {
                item.JarmuInfo();
            }
        }

    }
}
