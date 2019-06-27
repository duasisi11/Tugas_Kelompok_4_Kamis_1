using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 11;
            double b = 2;
            double c = a + b;
            double d = a * b;
            double e = a / b;
            double f = a % b;


            Console.WriteLine("Hasil penjumlahan = "+c);
            Console.WriteLine("Hasil penjumlahan "+ a +"+"+ b +" = "+c);
            Console.WriteLine("================================================");
            Console.WriteLine("Hasil perkalian = " + d);
            Console.WriteLine("Hasil perkalian " + a + "x" + b + " = " + d);
            Console.WriteLine("================================================");
            Console.WriteLine("Hasil pembagian = " + e);
            Console.WriteLine("Hasil pembagian " + a + "/" + b + " = " + e);
            Console.WriteLine("================================================");
            Console.WriteLine("Hasil modulo = " + f);
            Console.WriteLine("Hasil modulo " + a + "/" + b + " = " + f);
            Console.ReadKey();
        }

        public int jumlah(int input1, int input2)
        {
            return input1 + input2;
        }

        public int kali(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
