using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_check_refractor
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = int.Parse(Console.ReadLine());
            for (int num = 0; num <= prime; num++)
            {
                bool check = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} is prime -> {check}");
            }
        }
    }
}
