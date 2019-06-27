using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Perulangan1
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka : ");
            int a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    Console.WriteLine(i+".Aku bisa");
                }

                Console.ReadKey();
        }         
   }
}

