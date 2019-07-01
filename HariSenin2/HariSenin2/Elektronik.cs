using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Elektronik
    {
        public string tempat_simpan = "Lab Komputer";
        public string hak_milik = "Pusdiklat Tekfunghan";
        public int thn_sekarang = 2019;
        protected string sumber_pengadaan = "APBN 2019";
        

        public void info()
        {
            Console.WriteLine("======================>Daftar Inventaris Barang Elektronik Tahun :" + thn_sekarang +"<==========================");
            Console.WriteLine("Barang elektronik disimpan pada :" + tempat_simpan);
            Console.WriteLine("Kepemilikan barang elektronik ini yaitu :" + hak_milik);
            Console.WriteLine("Pengadaan barang elektronik dari sumber :" + sumber_pengadaan);


        }
    }
}
