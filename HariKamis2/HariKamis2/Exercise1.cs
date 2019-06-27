using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0)
            {
                if(a % 10 == 0){
                    Console.WriteLine(a + " : kelipatan 5 dan bilangan GENAP");
                }else{
                    Console.WriteLine(a + " : kelipatan 5 dan bilangan GANJIL");
                }
            }
            else
            {
                Console.WriteLine(a + " : -=BUKAN=- kelipatan 5");
            }
            Console.ReadKey();

        }         
    }
}
