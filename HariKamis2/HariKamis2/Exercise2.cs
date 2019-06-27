using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariKamis2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-= Nama Hari =- ");
            Console.WriteLine("1.Senin");
            Console.WriteLine("2.Selasa");
            Console.WriteLine("3.Rabu");
            Console.WriteLine("4.Kamis");
            Console.WriteLine("5.Jum'at");
            Console.WriteLine("6.Sabtu");

            Console.WriteLine("7.Minggu");
            Console.Write("Input angka sesuai nama hari : ");
            int pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1 : 
                    Console.WriteLine("Hari Senin");
                    break;
                case 2 :
                    Console.WriteLine("Hari Selasa");
                    break;
                case 3 :
                    Console.WriteLine("Hari Rabu");
                    break;
                case 4 :
                    Console.WriteLine("Hari Kamis");
                    break;
                case 5 :
                    Console.WriteLine("Hari Jum'at");
                    break;
                case 6 :
                    Console.WriteLine("Hari Sabtu");
                    break;
                case 7 :
                    Console.WriteLine("Hari Minggu");
                    break;
                default :
                    Console.WriteLine("Anda tidak memilih hari");
                    break;
            }
            Console.ReadKey();

        }         
    }
}
