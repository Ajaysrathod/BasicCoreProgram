using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {

        float CountHead = 0;
        float CountTail = 0;


        public void FlipCoins()
        {
            Console.WriteLine("Enter no of times to flip coin");
            int flipNum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < flipNum; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)

                    CountHead++;
                else
                    CountTail++;
            }
            Console.WriteLine("The HeadCount is " + CountHead);
            Console.WriteLine("The HeadCount is" + CountTail);
            float Headpercentage = (CountHead / flipNum) * 100;
            float tailpercentage = (CountTail / flipNum) * 100;
            Console.WriteLine("Head count percentage is:" + Headpercentage);
            Console.WriteLine("Tail count percentage is:" + tailpercentage);

        }
    }
}
