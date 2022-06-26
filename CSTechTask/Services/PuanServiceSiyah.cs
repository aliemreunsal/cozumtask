using CSTechTask.Concretes.Beyaz;
using CSTechTask.Concretes.Siyah;
using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Services
{
    class PuanServiceSiyah// Siyah taşlar üzerinde oluşan tehditin hesaplanması için oluşturulmuş service.
    {
        public double PuanHesapla(List<Beyaz> beyazTasListesi, List<Siyah> siyahTasListesi)
        {
            List<Kare> tehditKareleri=new();
            double p = 0;
            for (int i = 0; i < beyazTasListesi.Count; i++)
            {
                 tehditKareleri.AddRange(beyazTasListesi[i].tehditHesapla());// Beyaz taşların tehdit ettiği karelerin belirlenme işlemi.
               
            }
            for (int j = 0; j < siyahTasListesi.Count; j++)// Beyaz taşların tehdit ettiği karelerde bir siyah taş bulunup bulunmadığının kontrolü ve siyah taşın puan değerinin değiştirilmesi işlemi.
            {
                if (tehditKareleri.Contains(siyahTasListesi[j].mevcutKonum()))
                {
                    p += siyahTasListesi[j].Puan / 2;
                }
                else
                {
                    p += siyahTasListesi[j].Puan;
                }
            }



            return p;
        }
    }
}
