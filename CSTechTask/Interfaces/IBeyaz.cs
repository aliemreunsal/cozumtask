using CSTechTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Interfaces
{
    public interface IBeyaz // Beyaz taşların ayrımı için oluşturulmuş interface. 
    {
        List<Kare> tehditHesapla();

        Kare mevcutKonum();
    }
}
