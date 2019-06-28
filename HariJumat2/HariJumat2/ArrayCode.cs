using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariJumat2
{
    class ArrayCode
    {
        static void Main(string[] args)
        {
            // deklarasi array int.
            int[] intArray;
            // mengalokasikan memory untuk 5 nilai.
            intArray = new int[5];
            // inisialisasi array
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // mengakses elemen array dengan For
            Console.Write("For loop :");
            for (int i = intArray.Length-1; i >= 0; i--)
            {

                Console.Write(" " + intArray[i]);
            }

            Console.WriteLine(" ");

            int j = intArray.Length-1;
            Console.Write("For while :");
            while (j >= 0)
            {
                Console.Write(" " + intArray[j]);
                j--;
            } 


            /* Console.WriteLine("");
             Console.Write("For-each loop :");
             // menggunakan foreach
             foreach (int i in intArray)
             {

                 Console.Write(" " + i);
             } */

            Console.ReadKey();

        }
    }
}
