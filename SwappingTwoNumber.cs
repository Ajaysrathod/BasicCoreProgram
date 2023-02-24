using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwappingTwoNumber
    {
        public void SwappingTwoNumbers()
        {
            Console.WriteLine("Please enter number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number before swapping {0} and {1}", i, j);
            int temp = i;
            i = j;
            Console.WriteLine("The number after Swapping {0} and {1}", i, j);
        }
    }
}
