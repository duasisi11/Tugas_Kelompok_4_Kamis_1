using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSelasa2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contoh = new string[4] { "Matherboard", "Processor", "Power Supply", "Video Card" };
            object[] obj = new object[4] { "Handfone", 3.14, "A", true };

            foreach (string cth in contoh)
            {
                Console.WriteLine(cth);
            }

            Console.WriteLine(obj[3]);

            string contoh1 = contoh[3];
            Console.WriteLine(contoh1);

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
