using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Macan:Kucing
    {
        private string corak = "Bergaris Hitam";

        public void info()
        {
            Console.WriteLine("Jumlah Kaki Macan : " + base.jumlahKaki);
            Console.WriteLine("Ukuran Badan Macan : "+base.ukuranBadan);
            Console.WriteLine("Corak Macan : " + this.corak);
        }

        //Polimorphisme dapat menghasilkan output yang berbeda
        public void aksi() 
        {
            Console.WriteLine("Macan bisa berenang");
        }
    }
}
