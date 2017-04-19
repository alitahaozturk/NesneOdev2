﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Sıvı : ISıvı
    {
        private double carpan = 1.25;
        private double ozgulAgirlik;
        private int tonaj;
        private string urunAdi;
        private int eklenekUcret = 0;
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
        public double Sonuc(int mesafe)
        {
            return (Carpan*Tonaj*mesafe) + EklenecekUcret;
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
