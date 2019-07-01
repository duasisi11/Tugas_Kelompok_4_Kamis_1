using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Kucing
    {
        public int jumlahKaki = 4;
        public String peliharaan = "Bukan Peliharaan";
        protected String ukuranBadan = "Besar";

        public void info()
        {
            Console.WriteLine("Jumlah Kaki Kucing " + this.jumlahKaki);
            Console.WriteLine("Ukuran Badan Kucing : " + this.ukuranBadan);
        }
    }
}
