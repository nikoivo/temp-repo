using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wovel_or_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i': Console.WriteLine("vowel");break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': Console.WriteLine("number");break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
