using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Tugas_Kelompok_4_Kamis_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
        bool lanjut = true;

        Console.WriteLine("Jenis masakan :");
        Console.WriteLine("1.Masakan Padang");
        Console.WriteLine("2.Masakan Betawi");
        Console.WriteLine("3.Masakan Sunda");
        Console.Write("Pilih jenis masakan =");
        int jenis = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("==============================================================================");
        switch (jenis)
        {
            case 1:
                Console.WriteLine("Menu makanan : \n1.Ayam Goreng \n2.Nasi Rendang \n3.Nasi Telur Dadar");
                Console.Write("Pilih menu makanan =");
                break;
            case 2:
                Console.WriteLine("Menu makanan : \n1.Soto Betawi \n2.Nasi Kebuli Betawi");
                Console.Write("Pilih menu makanan =");
                break;
            case 3:
                Console.WriteLine("Menu makanan : \n1.Nasi Kuning \n2.Nasi Uduk");
                Console.Write("Pilih menu makanan =");
                break;
            default:
                Console.WriteLine("Maaf menu makanan tidak tersedia");
                break;
        }
        }
    }
}
