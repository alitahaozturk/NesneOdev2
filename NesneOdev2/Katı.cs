using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Katı : IKatı
    {
        public double Carpan { get; } = 1;

        public string UrunAdi { get; set; }

        public double PaketHacmi { get; set; }

        public int Tonaj { get; set; }

        public int EklenecekUcret { get; } = 1000;

        public double Sonuc(int mesafe)
        {
            return (Carpan * Tonaj * mesafe) + EklenecekUcret;
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
