using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Sıvı : ISıvı
    {
        public double Carpan { get; } = 1.25;

        public string UrunAdi { get; set; }

        public double OzgulAgirlik { get; set; }
        
        public int Tonaj { get; set; }

        public double Sonuc(int mesafe)
        {
            return (Carpan * Tonaj * mesafe);
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
