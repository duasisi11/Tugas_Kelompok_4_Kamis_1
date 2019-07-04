using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariRabu2
{
    class Program4
    {
    

        delegate int MathFunction(int a, int b);
        static void Main(string[] args)
        {
            Console.Write("Input angka 1 = ");
            int kiri = int.Parse(Console.ReadLine());
            Console.Write("Input operasi yang diinginkan [isi dengan *, /, +, -] ? ");
            string operasi = Console.ReadLine();

            Console.Write("Input angka 2 = ");
            int kanan = int.Parse(Console.ReadLine());

            MathFunction mathfunction;

            if (operasi == "+") mathfunction = Tambah;
            else if (operasi == "-") mathfunction = Kurang;
            else if (operasi == "*") mathfunction = Kali;
            else mathfunction = Bagi;

            int hasil = mathfunction(kiri, kanan);
            Console.WriteLine(string.Format("Hasil adalah {0}", hasil));
            Console.ReadKey();
        }

        static int Tambah(int a, int b)
        {
            return a + b;
        }

        static int Kurang(int a, int b)
        {
            return a - b;
        }

        static int Kali(int a, int b)
        {
            return a * b;
        }

        static int Bagi(int a, int b)
        {
            int hasil_hitung = 0;
            try
            {
                hasil_hitung = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Terdapat error : ");
                Console.WriteLine("Exception caught."+ e);
            }
            finally
            {
                 Console.WriteLine("Hasil tak terhingga");
            }
            return hasil_hitung;
        }
    }
}
