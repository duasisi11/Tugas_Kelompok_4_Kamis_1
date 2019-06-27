using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class While1
    {
        static void Main(string[] args)
        {

            Console.Write("Input angka : ");
            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            while(counter <= a && a != 0){     //selama sampai masih terpenuhi                                    
                Console.WriteLine(counter+ " ");
                  counter++;
            }
            Console.ReadKey();
        }
                
    }
}
