using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Johnson";
            byte age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int UEN = 27563571;

            Console.WriteLine("First Name: {0}",firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}",personalID);
            Console.WriteLine("Unique Employee Number: {0}",UEN);
        }
    }
}
