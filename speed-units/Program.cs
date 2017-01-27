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
            var meters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            float totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            float totalHours = hours + (minutes + seconds/60)/60;
            float kilometers = meters / 1000;
            float miles = meters / 1609;

            Console.WriteLine("{0}",(meters/totalSeconds));
            Console.WriteLine("{0}", (kilometers / totalHours));
            Console.WriteLine("{0}", (miles / totalHours));
        }
    }
}
