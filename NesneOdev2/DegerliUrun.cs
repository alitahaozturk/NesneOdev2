using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class DegerliUrun : IDegerliUrun
    {
        public double Carpan { get; } = 1.5;

        public string UrunAdi { get; set; }

        public int Hacmi { get; set; }

        public int Adet { get; set; }

        public int AdetAgirlik { get; set; }

        public int Tonaj { get; set; }

        public double Sonuc(int mesafe)
        {
            if (Tonaj / Hacmi >= 0.5)
            {
                return (Tonaj * Carpan + Hacmi * Carpan) / 2 + (mesafe * 1.5);
            }
            else
            {
                return ((Hacmi * Carpan) + (mesafe * 2));
            }
        }
        public void Yazdir(int mesafe)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Toplam Tutar: " + Sonuc(mesafe));
        }
    }
}
