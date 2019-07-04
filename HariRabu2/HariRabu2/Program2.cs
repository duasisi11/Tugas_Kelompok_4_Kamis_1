using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariRabu2
{
    class Program2
    {
        static void ProcessString(string s)
        {
            //if (s == null)
            if (s == null || s == "a" || s == "")
            {
                throw new ArgumentNullException(); //penanganan error apabila value nilainya = null
            }
        }

        static void Main(string[] args)
        {
            //string s = null;
            //string s = "isi variabel s";
            Console.Write("Input Kata : ");
            string s = Console.ReadLine();

            try
            {
                ProcessString(s);
                Console.WriteLine(s);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                Console.ReadKey();
            }
        }


    }
}
