using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTechTask.Concretes;


namespace CSTechTask.Concretes.BosKare
{
    public abstract class Bos : Kare// Boş karelerin aynı listede kullanılabilmesini sağlayan sınıf
    {
        public abstract int Puan { get; set; }
        public Bos(int x, int y) : base(x, y)
        {
        }
        public abstract Kare mevcutKonum();

        public abstract List<Kare> tehditHesapla();
    }
}
