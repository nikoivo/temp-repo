using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuries_to_nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            var centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            var minutes = (long)(60 * hours);
            var seconds = (60 * minutes);
            var milliseconds = (decimal)(1000 * seconds);
            var microseconds = (1000 * milliseconds);
            var nanoseconds = (1000 * microseconds);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", 
                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
