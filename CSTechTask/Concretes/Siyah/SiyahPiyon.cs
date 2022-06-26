using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Siyah
{
    public class SiyahPiyon : Siyah, ISiyah//Piyon nesnelerinin konumları ve puanları ile oluşturulmasını ve tehdit ettiği karelerin belirlenmesi için oluşturulan sınıf.
    {
        public override int Puan { get; set; }

        public SiyahPiyon(int a, int b) : base(a, b)
        {
            Puan = 1;
        }
        public override Kare mevcutKonum()
        {
            return this;
        }

        public override List<Kare> tehditHesapla()
        {
            List<Kare> tehditHesapla = new();
            Kare tehdit1 = new(mevcutKonum().x + 1, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit1);
            Kare tehdit2 = new(mevcutKonum().x - 1, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit2);
            return tehditHesapla;
        }
    }
}
