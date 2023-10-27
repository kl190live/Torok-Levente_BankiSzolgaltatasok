using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class MegtakaritasiSzamla : Szamla
    {
        public static double alapKamat = 1.1;
        private double kamat;

        public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
        }

        public double Kamat { get => kamat; set => kamat = value; }


        public override bool Kivesz(int osszeg)
        {
            {
                if (aktualisEgyenleg > 0)
                {
                    Console.WriteLine("Sikeres levétel");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nem sikerült levétel");
                    return false;
                }
            }
        }

        public void KamatJovairas()
        {
            aktualisEgyenleg = (int)(aktualisEgyenleg * kamat);
        }

    }
}

