using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSelasa2
{
    class Array2Dimensi
    {
       
        static void Main(string[] args)
        {
                int[,] Arr2D = new int[3,2]
                { { 1, 3 }, { 5, 7 }, { 7, 9 } };
                // Three-dimensional array.
   
                Console.WriteLine(Arr2D[0,1]);

                /*foreach (string a in Arr2D)
                {
                    Console.WriteLine(a);
                }*/

                    Console.Write("Press any key to continue...");
                Console.ReadKey(true);
        }
        
    }
}
