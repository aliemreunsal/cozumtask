using CSTechTask.Interfaces;
using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTechTask.Concretes;

namespace CSTechTask.Concretes.BosKare
{
    public class BosKare : Kare, IBos//Boş kare nesnelerinin belirlenmesi için oluşturulan sınıf.
    {
        public BosKare(int a, int b) : base(a, b)
        {
        }
        public Kare mevcutKonum()
        {
            return this;
        }

        public List<Kare> tehditHesapla()
        {
            return null;
        }
    }
}

