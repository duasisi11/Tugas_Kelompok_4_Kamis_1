using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HariSenin2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Elektronik el = new Elektronik();
            el.info();

            Computer pc = new Computer();
            pc.info();
            Console.WriteLine("=-----------------------------------------------==================---------------------------------=");

            Sound sound_dinding = new Sound();
            sound_dinding.info();

            Console.ReadKey();
        }
    }
}
