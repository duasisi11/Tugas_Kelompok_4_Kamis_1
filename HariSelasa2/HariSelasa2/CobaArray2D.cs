using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSelasa2
{
    class CobaArray2D
    {
        public void array()
        {
            //memasukkan inputan
            Console.Write("Masukkan jumlah baris :");
            byte baris = Convert.ToByte(Console.ReadLine());
            Console.Write("Masukkan jumlah kolom :");
            byte kolom = Convert.ToByte(Console.ReadLine())
                ;

            byte[,] array2D = new byte[baris, kolom];

            for (byte b = 0; b < baris; b++)
            {
                for (byte k = 0; k < kolom; k++)
                {
                    Console.Write("Masukkan nilai matriks array [{0},{1}] : ", b,k);
                    array2D[b,k] = Convert.ToByte(Console.ReadLine());
                }
            }

            for (byte b = 0; b < baris; b++)
            {
                for (byte k = 0; k < kolom; k++)
                {
                    Console.Write(array2D[b, k] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (byte b = 0; b < baris; b++)
            {
                for (byte k = 0; k < kolom; k++)
                {
                    Console.Write(array2D[b, k] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
