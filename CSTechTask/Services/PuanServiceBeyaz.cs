using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTechTask.Concretes.Beyaz;
using CSTechTask.Concretes.Siyah;

namespace CSTechTask.Services
{
    class PuanServiceBeyaz // Beyaz taşlar üzerinde oluşan tehditin hesaplanması için oluşturulmuş service.
    {
        public double PuanHesapla(List<Beyaz> beyazTasListesi, List<Siyah> siyahTasListesi)
        {
            List<Kare> tehditKareleri = new();
            double p = 0;
            for (int i = 0; i < siyahTasListesi.Count; i++)
            {
                 tehditKareleri.AddRange(siyahTasListesi[i].tehditHesapla());// Siyah taşların tehdit ettiği karelerin belirlenme işlemi.

            }
            for (int j = 0; j < beyazTasListesi.Count; j++)// Siyah taşların tehdit ettiği karelerde bir beyaz taş bulunup bulunmadığının kontrolü ve siyah taşın puan değerinin değiştirilmesi işlemi.
            {
                if (tehditKareleri.Contains(beyazTasListesi[j].mevcutKonum()))
                {
                    p += beyazTasListesi[j].Puan / 2;
                }
                else
                {
                    p += beyazTasListesi[j].Puan;
                }

            }


            return p;
        }
    }
}
