using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Sıvı : ISıvı
    {
        private double carpan = 1.25;
        private int km;
        private double ozgulAgirlik;
        private int tonaj;
        private string urunAdi;
        private int eklenekUcret = 1000;
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
        public int Km
        {
            get
            {
                return km;
            }
            set
            {
                km = value;
            }
        }
        public double OzgulAgirlik
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
        public int Tonaj
        {
            get
            {
                return tonaj;
            }
            set
            {
                tonaj = value;
            }
        }
        public int EklenecekUcret
        {
            get
            {
                return eklenekUcret;
            }
        }
        public double Sonuc()
        {
            return (Carpan*Km*Tonaj) + EklenecekUcret;
        }
        public void Yazdir()
        {
            Console.WriteLine("Ürün Adı : " + UrunAdi);
            Console.WriteLine("Tonajı : " + Tonaj);
            Console.WriteLine("Özgül Ağırlığı : " + OzgulAgirlik);
            Console.WriteLine("****************************************");
            Console.WriteLine("Toplam Tutar: ");
        }
    }
}
