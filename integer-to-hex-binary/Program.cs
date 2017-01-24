using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_to_hex_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(num, 16));
            Console.WriteLine(Convert.ToString(num,2));
        }
    }
}
