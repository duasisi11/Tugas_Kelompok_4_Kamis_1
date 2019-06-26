using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculate;

namespace Tugas_Kelompok_4_Kamis_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
        bool lanjut = true;
        int total1 = 0, total2 = 0, total3 = 0, total4 = 0, total5 = 0, total6 = 0, total7 = 0, harga, jumlah_porsi, menu, hasil1=0, hasil2=0, hasil3=0, jumlah=0;
        String confirm;
        
       while(lanjut)
       {

        Console.WriteLine("-=Inputan=-");
        Console.WriteLine("Jenis masakan :");
        Console.WriteLine("1.Masakan Padang");
        Console.WriteLine("2.Masakan Betawi");
        Console.WriteLine("3.Masakan Sunda");
        Console.Write("Pilih jenis masakan =");
        int jenis = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("==============================================================================");
        Console.Clear(); //untuk menghapus cetakan sebelumnya
            
        switch (jenis)
        {
            case 1 :
                    while(lanjut)
                    {
                        Console.WriteLine("Menu makanan : \n1.Ayam Goreng = Rp 10.000 \n2.Nasi Rendang = Rp 12.000 \n3.Nasi Telur Dadar = Rp 8.000");
                        Console.Write("Pilih menu makanan =");
                        menu = Convert.ToInt32(Console.ReadLine());
                      switch(menu)
                      {
                        case 1 : 
                            harga=10000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Ayam Goreng =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total1=harga*jumlah_porsi;
                            break;
                          case 2 :
                            harga=12000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Nasi Rendang =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total2=harga*jumlah_porsi;
                            break;
                          case 3 : 
                            harga=8000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Nasi Telur Dadar =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total3=harga*jumlah_porsi;
                        break;
                      }

                      hasil1 = total1 + total2 + total3;
                      Console.WriteLine("--------------------------------------=Hasil hitung masakan Padang=--------------------------------------------");
                      Console.WriteLine("Total Makanan 1 = " + total1 + "\nTotal Makanan 2 = " + total2 + "\nTotal Makanan 3 = " + total3);
                      Console.WriteLine("Total Makanan Padang =" + hasil1);
                        Console.Write("Apakah ingin memesan lagi (y/n) =");                    
                        confirm = Console.ReadLine();
                          if(confirm=="y")
                          {
                            lanjut=true;
                          }else{
                             lanjut=false;
                             break;
                          }
                  }

                break;
            case 2 :
                while (lanjut)
                {
                    Console.WriteLine("Menu makanan : \n1.Soto Betawi = Rp 8.000 \n2.Nasi Kebuli Betawi = Rp 9.000");
                    Console.Write("Pilih menu makanan =");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            harga = 8000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Soto Betawi =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total4 = harga * jumlah_porsi;
                            break;
                        case 2:
                            harga = 9000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Nasi Kebuli Betawi =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total5 = harga * jumlah_porsi;
                            break;
                    }
                    hasil2 = total4 + total5;
                    Console.WriteLine("--------------------------------------=Hasil hitung masakan Betawi=--------------------------------------------");
                    Console.WriteLine("Total Makanan 1 = " + total4 + "\nTotal Makanan 2 = " + total5);
                    Console.WriteLine("Total Makanan Betawi =" + hasil2);
                    Console.Write("Apakah ingin memesan lagi (y/n) =");
                    confirm = Console.ReadLine();
                    if (confirm == "y")
                    {
                        lanjut = true;
                    }
                    else
                    {
                        lanjut = false;
                        break;
                    }
                }

                break;
            case 3 :
                while (lanjut)
                {
                    Console.WriteLine("Menu makanan : \n1.Nasi Kuning = Rp 5.000 \n2.Nasi Uduk = Rp 6.000");
                    Console.Write("Pilih menu makanan =");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            harga = 5000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Nasi Kuning =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total6 = harga * jumlah_porsi;
                            break;
                        case 2:
                            harga = 6000;
                            Console.WriteLine("==============================================================================");
                            Console.Write("Berapa jumlah Nasi Uduk =");
                            jumlah_porsi = Convert.ToInt32(Console.ReadLine());
                            total7 = harga * jumlah_porsi;
                            break;
                    }
                    hasil3 = total6 + total7;
                    Console.WriteLine("--------------------------------------=Hasil hitung masakan Sunda=--------------------------------------------");
                    Console.WriteLine("Total Makanan 1 = " + total6 + "\nTotal Makanan 2 = " + total7);
                    Console.WriteLine("Total Makanan Sunda =" + hasil3);
                    Console.Write("Apakah ingin memesan lagi (y/n) =");
                    confirm = Console.ReadLine();
                    if (confirm == "y")
                    {
                        lanjut = true;
                    }
                    else
                    {
                        lanjut = false;
                        break;
                    }
                }
                
                break;
            default :
                Console.WriteLine("Maaf menu makanan tidak tersedia");
                break;
        }
            Console.Write("Apakah ingin pilih masakan lain (y/n) =");
            confirm = Console.ReadLine();
            if (confirm == "y")
            {
                lanjut = true;
            }
            else
            {
                lanjut = false;
                break;
            }
       }

             //Class1 a = new Class1();
           jumlah =hasil1+hasil2+hasil3;
           Console.WriteLine("--------------------------------------=Hasil hitung masakan Sunda=--------------------------------------------");
           Console.WriteLine("Total menu makanan Padang = " + hasil1 + "\nTotal menu makanan Betawi = " + hasil2 + "\nTotal menu makanan Sunda = " + hasil3);

             Console.WriteLine("Jumlah yang harus dibayarkan =" + jumlah);
             Console.WriteLine("==============================================================================");

             Console.Write("Masukkan jumlah bayar =");
             int bayar = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("==============================================================================");

             Console.WriteLine("Kembalian uang anda sebesar =" +(bayar-jumlah));
             Console.WriteLine("--------------------------------------=Tidak menerima Bon=--------------------------------------------");
             Console.ReadKey();
        }
    }
}
