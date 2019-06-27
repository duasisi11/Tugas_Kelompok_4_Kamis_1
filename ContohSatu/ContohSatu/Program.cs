using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohSatu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("-=Inputan=-");
            Console.Write("Nama anda : ");
            string nama = Console.ReadLine();
            Console.Write("Alamat anda : ");
            string alamat = Console.ReadLine();
            Console.Clear(); //untuk menghapus cetakan sebelumnya

            Console.WriteLine("-=Hasil Cetakan=-");
            /*Console.WriteLine("======================================");
            Console.WriteLine("Nama anda = " + nama);
            Console.WriteLine("Alamat anda = " + alamat);
            Console.WriteLine("======================================");
            */
            Console.WriteLine("======================================");
            Console.WriteLine("Nama anda = " + nama +" Alamat anda = " + alamat);
            Console.WriteLine("======================================");
            Console.WriteLine("Press any key to continue..."); 
            Console.ReadKey();

        }
    }
}
