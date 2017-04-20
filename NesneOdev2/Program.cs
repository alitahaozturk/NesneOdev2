using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            Console.Write("MusteriAdi :");
            kisi.MusteriAdi = Console.ReadLine();
            Console.Write("Adres :");
            kisi.Adres = Console.ReadLine();
            Console.Write("Telefon :");
            kisi.Telefon = Console.ReadLine();
            Console.Write("Fax :");
            kisi.Fax = Console.ReadLine();
            Console.Write("Mail :");
            kisi.Mail = Console.ReadLine();
            Console.Write("WebAdresi :");
            kisi.WebAdresi = Console.ReadLine();
            Console.Write("VergiNo :");
            kisi.VergiNo = Console.ReadLine();
            Console.Write("SiparisTarihi :");
            kisi.SiparisTarihi = Console.ReadLine();
            Console.Write("Taşınacak mesafe :");
            kisi.KM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Taşınacak Ürün (0:Sıvı,1:Katı,2:Gaz,3:Değerli Ürün) : ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 0:
                    SıvıIslemleri(kisi.KM);
                    break;
                case 1:
                    KatıIslemleri(kisi.KM);
                    break;
                case 2:
                    GazIslemleri(kisi.KM);
                    break;
                case 3:
                    DegerliUrunIslemleri(kisi.KM);
                    break;
                default:
                    Console.WriteLine("Lütfen belirtilen değerlerden birini seçiniz!..");
                    break;
            }
            Console.ReadLine();
        }

        private static void SıvıIslemleri(int mesafe)
        {
            Sıvı sivi = new Sıvı();
            Console.Write("Sıvı Ürünün Adı: ");
            sivi.UrunAdi = Console.ReadLine();
            Console.Write("Sıvı Ürünün Tonajı: ");
            sivi.Tonaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sıvı Ürünün Özgül Ağırlığı: ");
            sivi.OzgulAgirlik = Convert.ToInt32(Console.ReadLine());
            sivi.Yazdir(mesafe);
        }
        private static void KatıIslemleri(int mesafe)
        {
            Katı kati = new Katı();
            Console.Write("Katı Ürünün Adı: ");
            kati.UrunAdi = Console.ReadLine();
            Console.Write("Katı Ürünün Tonajı: ");
            kati.Tonaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Katı Ürünün Paket Hacmi: ");
            kati.PaketHacmi = Convert.ToInt32(Console.ReadLine());
            kati.Yazdir(mesafe);
        }
        private static void GazIslemleri(int mesafe)
        {
            Gaz gaz = new Gaz();
            Console.Write("Gaz Ürünün Adı: ");
            gaz.UrunAdi = Console.ReadLine();
            Console.Write("Gaz Ürünün Paket Hacmi: ");
            gaz.PaketHacmi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gaz Ürünün Tipi: ");
            gaz.Tipi = Console.ReadLine();
            gaz.Yazdir(mesafe);
        }
        private static void DegerliUrunIslemleri(int mesafe)
        {
            DegerliUrun du = new DegerliUrun();
            Console.Write("Değerli ürünün adı : ");
            du.UrunAdi = Console.ReadLine();
            Console.Write("Değerli ürünün hacmi : ");
            du.Hacmi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün tonajı : ");
            du.Tonaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün adedi : ");
            du.Adet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün adet ağırlığı : ");
            du.AdetAgirlik = Convert.ToInt32(Console.ReadLine());
            du.Yazdir(mesafe);
        }
    }
}
