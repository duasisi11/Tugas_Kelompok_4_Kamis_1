using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ganji_genap();
            //perulangan_for();

            Macan macan_sumatra = new Macan();
            macan_sumatra.info();
            macan_sumatra.aksi();

            Console.WriteLine("========================================");

            Singa singa_afrika = new Singa();
            singa_afrika.aksi();
            Console.ReadKey();

        }

        static void perulangan_for()
        {
            int jumlah = 0;

            for (int a = 1; a <= 10; a++)
            {
                jumlah += a;
                Console.Write(" + "+a);
            }

            Console.WriteLine(" ==> Hasil penjumlahan "+10+" angka = "+jumlah);
            Console.ReadKey();
        }

        static void ganji_genap()
        {
            int i, x = 0, angka;

            do
            {
                Console.Write("Inputkan angka : ");
                angka = Int32.Parse(Console.ReadLine());

                if (angka % 2 == 1)
                {
                    Console.Write("Deret angka GANJIL : ");
                    for (i = 1; i <= angka; i++)
                    {
                        Console.Write(i + " ");
                        x += i;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total penjumlahan = " + x);

                }
                else if (angka % 2 == 0)
                {

                    Console.Write("Deret angka GENAP : ");
                    for (i = 1; i <= angka; i++)
                    {
                        Console.Write(i + " ");
                        x += i;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total penjumlahan = " + x);
                }

                Console.WriteLine("Press 'E' to exit the process...");
            } while (Console.ReadKey().Key != ConsoleKey.E);

        }
    }
}
