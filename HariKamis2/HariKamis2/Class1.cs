using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka 1 :");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input angka 2 :");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 1 && b % 2 == 0)
            {
                Console.WriteLine(a + " angka ganjil dan " + b + " angka genap");
            }
            else if (a % 2 == 0 && b % 2 == 1)
            {
                Console.WriteLine(a + " angka genap dan " + b + " angka ganjil");
            }
            else if (a % 2 == 1 && b % 2 == 1)
            {
                Console.WriteLine(a + " angka ganjil dan " + b + " angka ganjil");
            }
            else
            {
                Console.WriteLine("Kedua angka genap");
            }
            Console.ReadKey();
        }
    }
}
