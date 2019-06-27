using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class While2
    {
        static void Main(string[] args)
        {
           
            //int counter = 0;
            bool flag = true;
            while(flag == true){
                Console.WriteLine("----------=GAME=---------- ");
                Console.WriteLine("1. Play Game ");
                Console.WriteLine("2. Intruction ");
                Console.WriteLine("3. Exit ");
                Console.Write("Input angka : ");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Mulai Permainan");
                    Console.ReadKey();
                }
                else if (a == 2)
                {
                    Console.WriteLine("Instruksi Permainan");                 
                    Console.ReadKey();
                }
                else if (a == 3)
                {
                    flag = false;
                    break;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Selain angka 1,2, dan 3");
                    Console.ReadKey();
                }
                //counter++;
            }
            
        }
                
    }
}
