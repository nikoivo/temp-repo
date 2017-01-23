using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexa_to_dec
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = 0xFE;
            var c2 = 0x37;
            var c3 = 0x10;

            Console.WriteLine(Convert.ToInt32(c1));
            Console.WriteLine(Convert.ToInt32(c2));
            Console.WriteLine(Convert.ToInt32(c3));
        }
    }
}
