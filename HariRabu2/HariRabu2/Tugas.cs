using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariRabu2
{
    class Tugas
    {
        delegate int MathFunction(int a, int b);

        static void Main(string[] args)
        {
            int kiri, kanan, hasil;
            bool flag=true;
            MathFunction mathfunction;

            do 
            {
                Console.WriteLine("Operasi Aritmatika ");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan ");
                Console.WriteLine("3. Perkalian ");
                Console.WriteLine("4. Pembagian ");
                Console.WriteLine("5. Keluar ");
                Console.Write("Pilih [1 s/d 5] : ");
                int pilih = int.Parse(Console.ReadLine());
                switch (pilih)
                {
                    case 1 :
                            Console.WriteLine("1. Operasi Penjumlahan ========> (+)");
                            Console.Write("Input angka 1 = ");
                            kiri = int.Parse(Console.ReadLine());
                            Console.Write("Input angka 2 = ");
                            kanan = int.Parse(Console.ReadLine());

                            mathfunction = Tambah;                     

                            hasil = mathfunction(kiri, kanan);
                            Console.WriteLine(string.Format("Hasil adalah {0}", hasil));

                            break;
                    case 2 :
                            Console.WriteLine("2. Operasi Pengurangan ========> (-) ");
                            Console.Write("Input angka 1 = ");
                            kiri = int.Parse(Console.ReadLine());
                            Console.Write("Input angka 2 = ");
                            kanan = int.Parse(Console.ReadLine());

                            mathfunction = Kurang;

                            hasil = mathfunction(kiri, kanan);
                            Console.WriteLine(string.Format("Hasil adalah {0}", hasil));

                            break;
                    case 3 :
                            Console.WriteLine("3. Operasi Perkalian ========> (*)");
                            Console.Write("Input angka 1 = ");
                            kiri = int.Parse(Console.ReadLine());
                            Console.Write("Input angka 2 = ");
                            kanan = int.Parse(Console.ReadLine());
                            
                            mathfunction = Kali;

                            hasil = mathfunction(kiri, kanan);
                            Console.WriteLine(string.Format("Hasil adalah {0}", hasil));

                            break;
                    case 4 :
                            Console.WriteLine("4. Operasi Pembagian ========> (/) ");
                            Console.Write("Input angka 1 = ");
                            kiri = int.Parse(Console.ReadLine());
                            Console.Write("Input angka 2 = ");
                            kanan = int.Parse(Console.ReadLine());

                            mathfunction = Bagi;

                            hasil = mathfunction(kiri, kanan);
                            Console.WriteLine(string.Format("Hasil adalah {0}", hasil));

                            break;
                    case 5 :
                            Console.WriteLine("Exit Program...");
                            flag = false;
                            break;
                    default :
                            Console.WriteLine("Anda tidak memilih pilihan apapun....");
                            break;
                 }
             }while(flag==true);
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
                return hasil_hitung;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Terdapat error : ");
                Console.WriteLine("Exception caught." + e);
            }
            finally
            {
                Console.WriteLine("Hasil tak terhingga");
            }
            return hasil_hitung;
        }
    }
}
