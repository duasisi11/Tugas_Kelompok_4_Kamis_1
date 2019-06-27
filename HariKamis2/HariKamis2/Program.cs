using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Program
    {
        static void Main(string[] args)
        {

            //CTRL + SPACE (AUTOCOMPLETE) - memilih option syntax bahasa pemrograman dari IDE 
            Console.Write("Input angka 1 :");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input angka 2 :");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b && a % 2 == 0)
            {
                Console.WriteLine(a + " angka terkecil dan genap");
            }
            Console.ReadKey();
        }
    }
}
