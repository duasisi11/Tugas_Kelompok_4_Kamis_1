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

            if (a == 0 && b == 0)
            {
                Console.WriteLine(a + " dan " + b + " bukan angka GANJIL maupun GENAP");
            }
            else if (a % 2 == 1 && b % 2 == 0)
            {
                Console.WriteLine(a + " adalah angka GANJIL");
                Console.WriteLine(b + " adalah angka GENAP");

            }
            else if (a % 2 == 0 && b % 2 == 1)
            {
                Console.WriteLine(a + " adalah angka GENAP");
                Console.WriteLine(b + " adalah angka GANJIL");
            }
            else if (a % 2 == 1 && b % 2 == 1)
            {
                Console.WriteLine(a + " adalah angka GANJIL");
                Console.WriteLine(b + " adalah angka GANJIL");
            }
            else if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine(a + " adalah angka GENAP");
                Console.WriteLine(b + " adalah angka GENAP");
            }
            Console.ReadKey();
        }
    }
}
