using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Harmonics
    {
        public void HarmonicSeries()
        {
            double Value = 1;
            Console.WriteLine("Enter user input");
            double range = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= range; n++)
            {
                Value = Value + (1 / Value);
            }
            Console.WriteLine("The harmonic series is:" + Value);
        }
    }
}
