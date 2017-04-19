using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Gaz : IGaz
    {
        private double carpan = 1.1;
        private double ozgulAgirlik;
        private string tipi;
        private string urunAdi;
        private int eklenekUcret = 4000;
        private int sonuc;
        public double Carpan
        {
            get
            {
                return carpan;
            }
        }
        public string UrunAdi
        {
            get
            {
                return urunAdi;
            }
            set
            {
                urunAdi = value;
            }
        }
        public double PaketHacmi
        {
            get
            {
                return ozgulAgirlik;
            }
            set
            {
                ozgulAgirlik = value;
            }
        }
        public string Tipi
        {
            get
            {
                return tipi;
            }
            set
            {
                tipi = value;
            }
        }
        public int EklenecekUcret
        {
            get
            {
                return eklenekUcret;
            }
        }
        public double Sonuc(int mesafe)
        {
            return (Carpan * PaketHacmi * mesafe) + EklenecekUcret;
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
