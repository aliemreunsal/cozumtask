using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTechTask.Model
{
    public class Kare // İnput değerli ve hamlelerin belirlenmesi için oluşturulmuş x ve y değerlerini oluşturan model. 
    {
        public int x { get; set; }
        public int y { get; set; }

        public Kare(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
