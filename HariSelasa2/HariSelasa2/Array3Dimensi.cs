using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSelasa2
{
    class Array3Dimensi
    {
       
        static void Main(string[] args)
        {
               

                int[, ,] array3D = new int[,,] 
                { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; //

                // The same array with dimensions specified.
                int[, ,] array3Da = new int[2, 2, 3] 
                { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

               System.Console.WriteLine(array3D[1, 0, 1]); //= 8 ==> [halaman, baris, kolom]
               System.Console.WriteLine(array3Da[1, 1, 2]); //= 12

               System.Console.WriteLine("=================3D Array Elements====================="); 
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            Console.Write("a[{0},{1},{2}]={3} ",i,j,k,array3D[i, j, k]);
                        }
                    }
                    Console.Write("//Halaman ke {0}", i);
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
        }
        
    }
}
