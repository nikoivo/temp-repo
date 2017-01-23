using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = bool.Parse(Console.ReadLine());

            if (phrase == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
