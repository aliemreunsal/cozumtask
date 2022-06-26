using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Beyaz

{
    public class BeyazKale : Beyaz, IBeyaz //Kale nesnelerinin konumları ve puanları ile oluşturulmasını ve tehdit ettiği karelerin belirlenmesi için oluşturulan sınıf.
    {
        public override int Puan { get; set; }

        public BeyazKale(int a, int b) : base(a, b)
        {
            Puan = 5;
        }
        public override Kare mevcutKonum()
        {
            return this;
        }

        public override List<Kare> tehditHesapla()
        {
            List<Kare> tehditHesapla = new();
            
            Kare tehdit1 = new(mevcutKonum().x + 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit1);
            Kare tehdit2 = new(mevcutKonum().x + 2, mevcutKonum().y);
            tehditHesapla.Add(tehdit2);
            Kare tehdit3 = new(mevcutKonum().x + 3, mevcutKonum().y);
            tehditHesapla.Add(tehdit3);
            Kare tehdit4 = new(mevcutKonum().x + 4, mevcutKonum().y);
            tehditHesapla.Add(tehdit4);
            Kare tehdit5 = new(mevcutKonum().x + 5, mevcutKonum().y);
            tehditHesapla.Add(tehdit5);
            Kare tehdit6 = new(mevcutKonum().x + 6, mevcutKonum().y);
            tehditHesapla.Add(tehdit6);
            Kare tehdit7 = new(mevcutKonum().x + 7, mevcutKonum().y);
            tehditHesapla.Add(tehdit7);
            Kare tehdit8 = new(mevcutKonum().x - 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit8);
            Kare tehdit9 = new(mevcutKonum().x - 2, mevcutKonum().y);
            tehditHesapla.Add(tehdit9);
            Kare tehdit10 = new(mevcutKonum().x - 3, mevcutKonum().y);
            tehditHesapla.Add(tehdit10);
            Kare tehdit11 = new(mevcutKonum().x - 4, mevcutKonum().y);
            tehditHesapla.Add(tehdit11);
            Kare tehdit12 = new(mevcutKonum().x - 5, mevcutKonum().y);
            tehditHesapla.Add(tehdit12);
            Kare tehdit13 = new(mevcutKonum().x - 6, mevcutKonum().y);
            tehditHesapla.Add(tehdit13);
            Kare tehdit14 = new(mevcutKonum().x - 7, mevcutKonum().y);
            tehditHesapla.Add(tehdit14);
            Kare tehdit15 = new(mevcutKonum().x, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit15);
            Kare tehdit16 = new(mevcutKonum().x, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit16);
            Kare tehdit17 = new(mevcutKonum().x, mevcutKonum().y + 3);
            tehditHesapla.Add(tehdit17);
            Kare tehdit18 = new(mevcutKonum().x, mevcutKonum().y + 4);
            tehditHesapla.Add(tehdit18);
            Kare tehdit19 = new(mevcutKonum().x, mevcutKonum().y + 5);
            tehditHesapla.Add(tehdit19);
            Kare tehdit20 = new(mevcutKonum().x, mevcutKonum().y + 6);
            tehditHesapla.Add(tehdit20);
            Kare tehdit21 = new(mevcutKonum().x, mevcutKonum().y + 7);
            tehditHesapla.Add(tehdit21);
            Kare tehdit22 = new(mevcutKonum().x, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit22);
            Kare tehdit23 = new(mevcutKonum().x, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit23);
            Kare tehdit24 = new(mevcutKonum().x, mevcutKonum().y - 3);
            tehditHesapla.Add(tehdit24);
            Kare tehdit25 = new(mevcutKonum().x, mevcutKonum().y - 4);
            tehditHesapla.Add(tehdit25);
            Kare tehdit26 = new(mevcutKonum().x, mevcutKonum().y - 5);
            tehditHesapla.Add(tehdit26);
            Kare tehdit27 = new(mevcutKonum().x, mevcutKonum().y - 6);
            tehditHesapla.Add(tehdit27);
            Kare tehdit28 = new(mevcutKonum().x, mevcutKonum().y - 7);
            tehditHesapla.Add(tehdit28);
            return tehditHesapla;
        }
    }
}
