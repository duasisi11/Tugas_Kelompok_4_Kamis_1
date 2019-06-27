using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class Percabangan
    {
        static void Main(string[] args)
        {
            bool a=true;
            while (a == true) { 
                Console.WriteLine("Tebak angka ganjil atau genap "); //CTRL + SPACE memilih option syntax bahasa pemrograman
                Console.Write("Input angka :");
                int inputan = int.Parse(Console.ReadLine());

                if (inputan % 2 == 0)
                {
                    Console.WriteLine("Anda menginput angka genap");
                    a = false;
                    Console.ReadKey();
                }else{
                    Console.WriteLine("Anda menginput angka ganjil");
                }
            }
        }
    }
}
