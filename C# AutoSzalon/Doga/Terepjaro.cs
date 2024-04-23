using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Terepjaro : Jarmu
    {
        public string Hajtas {  get; set; }
        public bool OffroadKepesseg {get ; set; }
        public int VontatoKepesseg { get; set; }
        public Terepjaro(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas,  string hajtas, int vontatokepesseg) : base( gyarto, modell, evjarat, alapar, kilometeroraAllas)
        {
            Hajtas = hajtas;
            OffroadKepesseg = false;
            VontatoKepesseg = vontatokepesseg;
        }

        public void OffroadCsomagFelszerel()
        {
            OffroadKepesseg = true;
            Alapar += 10000;
            Console.Write("Az Offroad csomag beszserelese utan az auo adatai: ");
            base.JarmuInfo();
        }

        public void VontatóképessegBeallitasa(int kepesseg)
        {
            VontatoKepesseg = kepesseg;
            Console.WriteLine($"A terepjaro uj vontatokepessége: {VontatoKepesseg}");
        }

    }
}
