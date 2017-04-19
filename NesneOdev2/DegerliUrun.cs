using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class DegerliUrun : IDegerliUrun
    {
        private double carpan = 1.5;
        private int hacmi;
        private int tonaj;
        private string urunAdi;
        private int adet;
        private int agirlik; 
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
        public int Hacmi
        {
            get
            {
                return hacmi;
            }
            set
            {
                hacmi = value;
            }
        }
        public int Adet
        {
            get
            {
                return adet;
            }
            set
            {
                adet = value;
            }
        }
        public int Agirlik
        {
            get
            {
                return agirlik;
            }
            set
            {
                agirlik = value;
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
        public double Sonuc(int mesafe)
        {
            if(Agirlik/Hacmi >= 0.5)
            {
                return (Agirlik * Carpan + Hacmi * Carpan) / (2 + mesafe * 1.5);
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
