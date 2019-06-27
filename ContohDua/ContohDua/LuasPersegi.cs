using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class LuasPersegi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Program ini Mengitung Luas Persegi Panjang");
            Console.WriteLine("__________________________________________________");

            Console.Write("Silahkan input panjang(P) persegi panjang =");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Silakan input lebar(L) persegi panjang =");
            int l = int.Parse(Console.ReadLine());

            int luas = p * l;
            //Console.Clear();
            Console.WriteLine("##################################################");
            Console.WriteLine("Hasil perhitungan luas persegi panjang dengan P :" + p + " dan L :" + l + " adalah " + luas);
            Console.ReadKey();
        }
    }
}
