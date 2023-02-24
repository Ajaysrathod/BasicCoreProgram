using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class ConsonantVowel
    {
        public void ConsonantOrVowel()
        {
            Console.WriteLine("Please provide input string");
            string input = Console.ReadLine();

            for (int i = 0; i <= input.Length; i++)
            {
                if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                 if (input[i] >= 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')

                        Console.WriteLine("The alphabate {0} is vowel", input[i]);
                 else
                        Console.WriteLine("The alphabate {0] is consonant", input[i]);
                }
            }
        }
    }
}
