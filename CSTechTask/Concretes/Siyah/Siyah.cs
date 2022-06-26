using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Concretes.Siyah
{
    public abstract class Siyah : Kare// Siyah taşların aynı listede kullanılabilmesini sağlayan sınıf
    {
        public abstract int Puan { get; set; }
        public Siyah(int x, int y) : base(x, y)
        {
        }
        public abstract Kare mevcutKonum();

        public abstract List<Kare> tehditHesapla();
    }
}
