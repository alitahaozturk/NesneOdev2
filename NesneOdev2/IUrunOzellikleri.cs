using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    interface ISıvı
    {
        string UrunAdi { get; }
        int Tonaj { get; }
        double Carpan { get; }
        double OzgulAgirlik { get; }
        int EklenecekUcret { get; }
    }
    interface IKatı
    {
        string UrunAdi { get; }
        int Tonaj { get; }
        double Carpan { get; }
        double PaketHacmi { get; }
        int EklenecekUcret { get; }
    }
    interface IGaz
    {
        string UrunAdi { get; }
        string Tipi { get; }
        double Carpan { get; }
        double PaketHacmi { get; }
        int EklenecekUcret { get; }
    }
    interface IDegerliUrun
    {
        string UrunAdi { get; }
        int Tonaj { get; }
        int Adet { get; }
        int Agirlik { get; }
        int Hacmi { get; } 
    }
}
