using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka 1 :");
            int a = int.Parse(Console.ReadLine());

            if (a % 10 == 0)
            {
                Console.WriteLine(a + " angka kelipatan 10");
            }
            else
            {
                Console.WriteLine(a + " BUKAN angka kelipatan 10");
            }
            Console.ReadKey();
        }
    }
}
