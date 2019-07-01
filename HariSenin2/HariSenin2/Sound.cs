using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Sound:Elektronik
    {
        private int harga_barang = 1500000;
        public int jml_unit = 2;
        public int thn_pengadaan = 2014;
        private string kondisi = "Baik";

        public void info()
        {
            Console.WriteLine("Harga Sound = " + harga_barang);
            Console.WriteLine("Jumlah Unit = " + jml_unit);
            Console.WriteLine("Kondisi Sound = " + kondisi);
            Console.WriteLine("Nilai/harga barang saat ini ="+nilai_barang());
        }

        public int nilai_barang()
        {
            return harga_barang / (thn_sekarang - thn_pengadaan);
        }
    }
}
