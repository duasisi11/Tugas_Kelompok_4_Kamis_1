using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class DoWhile
    {
        static void Main(string[] args)
        {

            Console.Write("Input angka : ");
            int a = int.Parse(Console.ReadLine());
            int counter = a;
            do
            {
                Console.WriteLine(counter + " ");
                counter--;
            } while(counter >= 0 && a != 0);     //(>=) selama masih terpenuhi maka [kerjakan]                                   
            Console.ReadKey();
        }
                
    }
}
