using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariJumat2
{
    class Program
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
            for (int i = 0; i < intArray.Length; i++)
            {

                Console.Write(" " + intArray[i]);
            }

            Console.WriteLine("");
            Console.Write("For-each loop :");
            // menggunakan foreach
            foreach (int i in intArray)
            {

                Console.Write(" " + i);
            }

            Console.WriteLine("");
            Console.Write("while loop :");
            // menggunakan while
            int j = 0;
            while (j < intArray.Length)
            {

                Console.Write(" " + intArray[j]);

                j++;

            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");
            // menggunakan do-while
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);

            Console.ReadKey();

        }
    }
}
