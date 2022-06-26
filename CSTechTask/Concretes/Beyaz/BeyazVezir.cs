using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Beyaz
{
    public class BeyazVezir : Beyaz, IBeyaz//Vezir nesnelerinin konumları ve puanları ile oluşturulmasını ve tehdit ettiği karelerin belirlenmesi için oluşturulan sınıf.
    {
        public override int Puan { get; set; }

        public BeyazVezir(int a, int b) : base(a, b)
        {
            Puan = 9;
        }
        public override Kare mevcutKonum()
        {
            return this;
        }

        public override List<Kare> tehditHesapla()
        {
            List<Kare> tehditHesapla = new();
            
            Kare tehdit1 = new(mevcutKonum().x + 1, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit1);
            Kare tehdit2 = new(mevcutKonum().x + 2, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit2);
            Kare tehdit3 = new(mevcutKonum().x + 3, mevcutKonum().y + 3);
            tehditHesapla.Add(tehdit3);
            Kare tehdit4 = new(mevcutKonum().x + 4, mevcutKonum().y + 4);
            tehditHesapla.Add(tehdit4);
            Kare tehdit5 = new(mevcutKonum().x + 5, mevcutKonum().y + 5);
            tehditHesapla.Add(tehdit5);
            Kare tehdit6 = new(mevcutKonum().x + 6, mevcutKonum().y + 6);
            tehditHesapla.Add(tehdit6);
            Kare tehdit7 = new(mevcutKonum().x + 7, mevcutKonum().y + 7);
            tehditHesapla.Add(tehdit7);
            Kare tehdit8 = new(mevcutKonum().x - 1, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit8);
            Kare tehdit9 = new(mevcutKonum().x - 2, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit9);
            Kare tehdit10 = new(mevcutKonum().x - 3, mevcutKonum().y - 3);
            tehditHesapla.Add(tehdit10);
            Kare tehdit11 = new(mevcutKonum().x - 4, mevcutKonum().y - 4);
            tehditHesapla.Add(tehdit11);
            Kare tehdit12 = new(mevcutKonum().x - 5, mevcutKonum().y - 5);
            tehditHesapla.Add(tehdit12);
            Kare tehdit13 = new(mevcutKonum().x - 6, mevcutKonum().y - 6);
            tehditHesapla.Add(tehdit13);
            Kare tehdit14 = new(mevcutKonum().x - 7, mevcutKonum().y - 7);
            tehditHesapla.Add(tehdit14);
            Kare tehdit15 = new(mevcutKonum().x + 1, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit15);
            Kare tehdit16 = new(mevcutKonum().x + 2, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit16);
            Kare tehdit17 = new(mevcutKonum().x + 3, mevcutKonum().y - 3);
            tehditHesapla.Add(tehdit17);
            Kare tehdit18 = new(mevcutKonum().x + 4, mevcutKonum().y - 4);
            tehditHesapla.Add(tehdit18);
            Kare tehdit19 = new(mevcutKonum().x + 5, mevcutKonum().y - 5);
            tehditHesapla.Add(tehdit19);
            Kare tehdit20 = new(mevcutKonum().x + 6, mevcutKonum().y - 6);
            tehditHesapla.Add(tehdit20);
            Kare tehdit21 = new(mevcutKonum().x + 7, mevcutKonum().y - 7);
            tehditHesapla.Add(tehdit21);
            Kare tehdit22 = new(mevcutKonum().x - 1, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit22);
            Kare tehdit23 = new(mevcutKonum().x - 2, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit23);
            Kare tehdit24 = new(mevcutKonum().x - 3, mevcutKonum().y + 3);
            tehditHesapla.Add(tehdit24);
            Kare tehdit25 = new(mevcutKonum().x - 4, mevcutKonum().y + 4);
            tehditHesapla.Add(tehdit25);
            Kare tehdit26 = new(mevcutKonum().x - 5, mevcutKonum().y + 5);
            tehditHesapla.Add(tehdit26);
            Kare tehdit27 = new(mevcutKonum().x - 6, mevcutKonum().y + 6);
            tehditHesapla.Add(tehdit27);
            Kare tehdit28 = new(mevcutKonum().x - 7, mevcutKonum().y + 7);
            tehditHesapla.Add(tehdit28);

            Kare tehdit29 = new(mevcutKonum().x + 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit29);
            Kare tehdit30 = new(mevcutKonum().x + 2, mevcutKonum().y);
            tehditHesapla.Add(tehdit30);
            Kare tehdit31 = new(mevcutKonum().x + 3, mevcutKonum().y);
            tehditHesapla.Add(tehdit31);
            Kare tehdit32 = new(mevcutKonum().x + 4, mevcutKonum().y);
            tehditHesapla.Add(tehdit32);
            Kare tehdit33 = new(mevcutKonum().x + 5, mevcutKonum().y);
            tehditHesapla.Add(tehdit33);
            Kare tehdit34 = new(mevcutKonum().x + 6, mevcutKonum().y);
            tehditHesapla.Add(tehdit34);
            Kare tehdit35 = new(mevcutKonum().x + 7, mevcutKonum().y);
            tehditHesapla.Add(tehdit35);
            Kare tehdit36 = new(mevcutKonum().x - 1, mevcutKonum().y);
            tehditHesapla.Add(tehdit36);
            Kare tehdit37 = new(mevcutKonum().x - 2, mevcutKonum().y);
            tehditHesapla.Add(tehdit37);
            Kare tehdit38 = new(mevcutKonum().x - 3, mevcutKonum().y);
            tehditHesapla.Add(tehdit38);
            Kare tehdit39 = new(mevcutKonum().x - 4, mevcutKonum().y);
            tehditHesapla.Add(tehdit39);
            Kare tehdit40 = new(mevcutKonum().x - 5, mevcutKonum().y);
            tehditHesapla.Add(tehdit40);
            Kare tehdit41 = new(mevcutKonum().x - 6, mevcutKonum().y);
            tehditHesapla.Add(tehdit41);
            Kare tehdit42 = new(mevcutKonum().x - 7, mevcutKonum().y);
            tehditHesapla.Add(tehdit42);
            Kare tehdit43 = new(mevcutKonum().x, mevcutKonum().y + 1);
            tehditHesapla.Add(tehdit43);
            Kare tehdit44 = new(mevcutKonum().x, mevcutKonum().y + 2);
            tehditHesapla.Add(tehdit44);
            Kare tehdit45 = new(mevcutKonum().x, mevcutKonum().y + 3);
            tehditHesapla.Add(tehdit45);
            Kare tehdit46 = new(mevcutKonum().x, mevcutKonum().y + 4);
            tehditHesapla.Add(tehdit46);
            Kare tehdit47 = new(mevcutKonum().x, mevcutKonum().y + 5);
            tehditHesapla.Add(tehdit47);
            Kare tehdit48 = new(mevcutKonum().x, mevcutKonum().y + 6);
            tehditHesapla.Add(tehdit48);
            Kare tehdit49 = new(mevcutKonum().x, mevcutKonum().y + 7);
            tehditHesapla.Add(tehdit49);
            Kare tehdit50 = new(mevcutKonum().x, mevcutKonum().y - 1);
            tehditHesapla.Add(tehdit50);
            Kare tehdit51 = new(mevcutKonum().x, mevcutKonum().y - 2);
            tehditHesapla.Add(tehdit51);
            Kare tehdit52 = new(mevcutKonum().x, mevcutKonum().y - 3);
            tehditHesapla.Add(tehdit52);
            Kare tehdit53 = new(mevcutKonum().x, mevcutKonum().y - 4);
            tehditHesapla.Add(tehdit53);
            Kare tehdit54 = new(mevcutKonum().x, mevcutKonum().y - 5);
            tehditHesapla.Add(tehdit54);
            Kare tehdit55 = new(mevcutKonum().x, mevcutKonum().y - 6);
            tehditHesapla.Add(tehdit55);
            Kare tehdit56 = new(mevcutKonum().x, mevcutKonum().y - 7);
            tehditHesapla.Add(tehdit56);
            return tehditHesapla;
        }
    }
}
