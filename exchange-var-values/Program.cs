using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange_var_values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
