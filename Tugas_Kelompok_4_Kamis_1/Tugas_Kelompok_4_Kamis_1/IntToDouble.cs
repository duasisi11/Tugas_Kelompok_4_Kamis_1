using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int luas;
            Console.WriteLine("\nMenghitung ? ");
            var name = Console.ReadLine();
            Console.WriteLine("\nInput nilai r ? ");
            /* Converts to integer type */
            int sisi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan phi : ");
            /* Converts to double type */
            double doubleVal = Convert.ToDouble(Console.ReadLine());
            var date = DateTime.Now;

            luas = sisi * sisi;

            Console.WriteLine("\nHello, {0}, on {1:d} at {1:t}", name, date);
            Console.WriteLine("\nHasil Menghitung Luas Persegi "+luas);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
