using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("____________________________________");

            Console.Write("Silahkan input angka pertama =");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Silakan input angka kedua =");
            int input2 = int.Parse(Console.ReadLine());

            //int hasilpenjumlahan = input1 + input2;
            //int hasilperkalian = input1 * input2;

            //Console.Clear();
            Console.WriteLine("####################################");
            Program prog = new Program();
            int hasil_jml = prog.jumlah(input1, input2);
            int hasil_kali = prog.kali(input1, input2);

            Console.WriteLine("Hasil penjumlahan " + input1 + " + " + input2 + " = " + hasil_jml);
            Console.WriteLine("Hasil perkalian " + input1 + " x " + input2 + " = " + hasil_kali);
            Console.ReadKey();
        }

    }
}
