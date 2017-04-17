using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    public class Kisi
    {
        public string MusteriAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string WebAdresi { get; set; }
        public string VergiNo { get; set; }
        public string SiparisTarihi { get; set; }
        public void Yazdir()
        {
            Console.WriteLine("MusteriAdi : " + MusteriAdi);
            Console.WriteLine("Adres : " + Adres);
            Console.WriteLine("Telefon : " + Telefon);
            Console.WriteLine("Fax : " + Fax);
            Console.WriteLine("Mail : " + Mail);
            Console.WriteLine("WebAdresi : " + WebAdresi);
            Console.WriteLine("VergiNo : " + VergiNo);
            Console.WriteLine("SiparisTarihi : " + SiparisTarihi);
        }
    }
}
