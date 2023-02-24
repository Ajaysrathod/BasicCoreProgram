using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year you want to check for leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("The {0} is leap year", year);
            }
            else
            {
                Console.WriteLine("The {0} is not leap year", year);
            }
        }
    }
}
