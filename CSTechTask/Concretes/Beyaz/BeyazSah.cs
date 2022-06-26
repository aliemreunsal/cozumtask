using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Beyaz
{
    public class BeyazSah : Beyaz, IBeyaz//Şah nesnelerinin konumları ve puanları ile oluşturulmasını ve tehdit ettiği karelerin belirlenmesi için oluşturulan sınıf.
    {
        public override int Puan { get; set; }

        public BeyazSah(int a, int b) : base(a, b)
        {
            Puan = 100;
        }
        public override Kare mevcutKonum()
        {
            return this;
        }

        public override List<Kare> tehditHesapla()
        {
            List<Kare> tehditHesapla = new();
            
            Kare tehdit1 = new(mevcutKonum().x, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit1);
            Kare tehdit2 = new(mevcutKonum().x, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit2);
            Kare tehdit3 = new(mevcutKonum().x + 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit3);
            Kare tehdit4 = new(mevcutKonum().x - 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit4);
         
            return tehditHesapla;
        }
    }
}
