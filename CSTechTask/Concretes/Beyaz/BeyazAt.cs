using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Beyaz

{
    public class BeyazAt : Beyaz, IBeyaz //At nesnelerinin konumları ve puanları ile oluşturulmasını ve tehdit ettiği karelerin belirlenmesi için oluşturulan sınıf.
    {
        public override int Puan { get; set; }
        public BeyazAt(int a, int b) : base(a, b)
        {
            Puan = 3;
        }
        public override Kare mevcutKonum()
        {
            return this;
        }

        public override List<Kare> tehditHesapla()
        {
            List<Kare> tehditHesapla = new();
           
            Kare tehdit1 = new(mevcutKonum().x + 2, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit1);
            Kare tehdit2 = new(mevcutKonum().x + 2, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit2);
            Kare tehdit3 = new(mevcutKonum().x - 2, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit3);
            Kare tehdit4 = new(mevcutKonum().x - 2, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit4);
            Kare tehdit5 = new(mevcutKonum().x + 1, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit5);
            Kare tehdit6 = new(mevcutKonum().x + 1, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit6);
            Kare tehdit7 = new(mevcutKonum().x - 1, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit7);
            Kare tehdit8 = new(mevcutKonum().x - 1, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit8);
            return tehditHesapla;
        }
    }
}
