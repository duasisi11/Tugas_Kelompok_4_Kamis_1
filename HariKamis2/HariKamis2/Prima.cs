using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Prima
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka : ");
            int a = int.Parse(Console.ReadLine());
            bool prima = true;
           
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        prima = false;
                    }
                }


                if (prima == false || a < 2)
                {
                    Console.WriteLine(a + " --BUKAN-- bilangan PRIMA");
                }
                else
                {
                    Console.WriteLine(a + " bilangan PRIMA");
                }
                Console.ReadKey();
           
        }         
   }
}

