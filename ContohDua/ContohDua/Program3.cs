using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("____________________________________");

            Console.Write("Silahkan input angka pertama =");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Silakan input angka kedua =");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("============================================================================================");

            if (input1 > input2)
            {
                Console.WriteLine("Input angka pertama '" + input1 + "' lebih BESAR dari input angka kedua '" + input2+"'");
                Console.WriteLine("============================================================================================");
                Console.ReadKey();
            }
            else if (input1 < input2)
            {
                Console.WriteLine("Input angka pertama '" + input1 + "' lebih KECIL dari input angka kedua '" + input2 + "'");
                Console.WriteLine("============================================================================================");
                Console.ReadKey();
            }
            else if(input1==input2)
            {
                Console.WriteLine("Input angka pertama yaitu '" + input1 + "' sama dengan input angka kedua '" + input2 + "'");
                Console.WriteLine("============================================================================================");
                Console.ReadKey();
            }
        }
    }
}
