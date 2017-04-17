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
            Kisi kisi = new Kisi
            {
                MusteriAdi = "ali Taha",
                Adres = "Şirinevler istanbul 7.sk",
                Telefon = "05389655522",
                Fax = "1235497",
                Mail = "a@a.com",
                WebAdresi = "www.a.com",
                VergiNo = "161616",
                SiparisTarihi = DateTime.Now.ToShortDateString()
            };
            kisi.Yazdir();
            Sıvı sivi = new Sıvı
            {
                Km = 200,
                UrunAdi = "SÜT",
                Tonaj =25,
                OzgulAgirlik = 15
            };

            Console.ReadLine();
        }
    }
}
