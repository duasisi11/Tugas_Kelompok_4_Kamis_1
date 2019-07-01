using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class RefWhile
    {
        static void Main(string[] abc){
            int jumlah = 1;

            while (jumlah <= 10)
            {
                Console.WriteLine(jumlah + ". Aku belajar C#");
                jumlah++;
            }

            Console.ReadKey();
        }
    }
}
