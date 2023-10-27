using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class HitelSzamla : Szamla
    {
        private int hitelKeret;

        public HitelSzamla(Tulajdonos tulajdonos, int hitelKeret) : base(tulajdonos)
        {
            this.hitelKeret = hitelKeret;

        }

        public int HitelKeret { get => hitelKeret; }

        public override bool Kivesz(int osszeg)
        {
            {
                if (aktualisEgyenleg < hitelKeret || osszeg == hitelKeret)
                {
                    hitelKeret -= osszeg;
                    return true;
                }
                else
                {
                    Console.WriteLine("Nincs annyi pénz a számládon!");
                    return false;
                }
            }
        }
    }
}