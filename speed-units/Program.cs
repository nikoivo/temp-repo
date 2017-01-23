using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed_units
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine());
            var seconds = double.Parse(Console.ReadLine());
            double totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            double totalHours = hours + (minutes/60) + (seconds/60)/60;
            double kilometers = meters / 1000.0;
            double miles = meters / 1609;

            Console.WriteLine("{0:f6}",(meters/totalSeconds));
            Console.WriteLine("{0:f6}", (kilometers / totalHours));
            Console.WriteLine("{0:f6}", (miles / totalHours));
        }
    }
}
