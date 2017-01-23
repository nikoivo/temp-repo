using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangleWidth = int.Parse(Console.ReadLine());
            var rectangleHeight = int.Parse(Console.ReadLine());

            Console.WriteLine(2*rectangleHeight + 2*rectangleWidth);
            Console.WriteLine(rectangleWidth*rectangleHeight);
            Console.WriteLine(Math.Sqrt(rectangleWidth*rectangleWidth + rectangleHeight*rectangleHeight));
        }
    }
}
