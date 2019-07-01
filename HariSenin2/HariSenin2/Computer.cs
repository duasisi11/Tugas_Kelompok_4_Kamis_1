using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Computer:Elektronik
    {
        private int harga_barang = 7000000;
        public int jml_unit = 50;
        public int thn_pengadaan = 2016;
        private string kondisi = "Baik";

        public void info()
        {
            Console.WriteLine("Harga Computer = " + harga_barang);
            Console.WriteLine("Jumlah Unit = " + jml_unit);
            Console.WriteLine("Kondisi Computer = " + kondisi);
            Console.WriteLine("Nilai/harga barang saat ini ="+nilai_barang()); 
        }

        public int nilai_barang()
        {
            return harga_barang/(thn_sekarang - thn_pengadaan);
        }
        
    }
}
