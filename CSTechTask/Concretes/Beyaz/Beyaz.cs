using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Beyaz
{
    public abstract class Beyaz : Kare // Beyaz taşların aynı listede kullanılabilmesini sağlayan sınıf.
    {
        public abstract int Puan { get; set; }
        public Beyaz(int x, int y) : base(x, y)
        {
        }
        public abstract Kare mevcutKonum();

        public abstract List<Kare> tehditHesapla();
    }
}
