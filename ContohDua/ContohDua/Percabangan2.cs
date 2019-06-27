using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohDua
{
    class Percabangan2
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Pilih bonus anda");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Uang");
            Console.WriteLine("2. Rumah");
            Console.WriteLine("3. Tabungan");
            Console.WriteLine("__________________________________");
            Console.Write("Pilihan anda [1-3] : ");
            int opsi = int.Parse(Console.ReadLine());

                if (opsi == 1)
                {
                    Console.WriteLine("Anda memilih opsi 1");
                    Console.ReadKey();
                }else if(opsi == 2){
                    Console.WriteLine("Anda memilih opsi 2");
                    Console.ReadKey();
                }else if (opsi == 3){
                    Console.WriteLine("Anda memilih opsi 3");
                    Console.ReadKey();
                }else{
                    Console.WriteLine("Anda memilih semuanya..");
                    Console.ReadKey();
                }
         }
    }
}
