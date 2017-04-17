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
        int Km { get; } 
        double OzgulAgirlik { get; }
        int EklenecekUcret { get; }

    }
}
