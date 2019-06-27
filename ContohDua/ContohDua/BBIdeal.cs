using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class BBIdeal
    {
        static void Main(string[] args)
        {
            Console.Write("Input berat badan : ");
            int beratbadan = int.Parse(Console.ReadLine());
            Console.Write("Input tinggi badan : ");
            int tinggibadan=int.Parse(Console.ReadLine());

            int BBideal = tinggibadan - 110;
            if (beratbadan > BBideal)
            {
                Console.WriteLine("Berat badan anda belum ideal ");
                int selisihBB = beratbadan - BBideal;
                Console.WriteLine("===========================================");
                Console.WriteLine("Selisih berat badan anda =" + selisihBB);
                Console.WriteLine("===========================================");
                if (selisihBB >= 25)
                {
                    Console.WriteLine("Anda Overweight");
                }else{
                    Console.WriteLine("Hati-hati Overweight");
                }
            }
            else
            {
                int selisihBB = BBideal-beratbadan;
                if (selisihBB < 25 && selisihBB > 10)
                {
                    Console.WriteLine("Berat badan anda sudah ideal");
                    Console.WriteLine("Anda sudah cukup sehat");
                }else{
                    Console.WriteLine("Anda terlalu kurus...");
                }
            }

            Console.ReadKey();
        }
    }
}
