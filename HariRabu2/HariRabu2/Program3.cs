using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariRabu2
{
    class Program3
    {
        int hasil;

        Program3()
        {
            hasil=0;
        }

        public void Bagi(int number1, int number2)
        {
            try
            {
                hasil=number1/number2;
            }
            catch (DivideByZeroException e) //penanganan error apabila value nilainya = 0 / zero
            {
                Console.WriteLine("Terdapat error : ");
                Console.WriteLine("Exception caught."+ e);
            }
            finally
            {
                Console.WriteLine("Hasil pembagian : "+hasil);
            }
        }

        static void Main(string[] args)
        {
            Program3 pembagian = new Program3();
            Console.Write("Masukkan angka1 : ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Masukkan angka2 : ");
            int number2 = Int32.Parse(Console.ReadLine());

            pembagian.Bagi(number1,number2);

            Console.ReadKey();
        }


    }
}
