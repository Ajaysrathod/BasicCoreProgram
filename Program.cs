﻿namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core program");
            Console.WriteLine("1.FlipCoin\n2:Leap Year\n3:PowerOfTwo\n4:Harmonics\n5:FindQuotient\n6:SwappingTwoNumber");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Leap();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.PowerOf2();
                    break;
                case 4:
                    Harmonics harmonics = new Harmonics();
                    harmonics.HarmonicSeries();
                    break;
                case 5:
                    FindQuotient findQuotient = new FindQuotient();
                    findQuotient.FindQuotients();
                    break;
                case 6:
                    SwappingTwoNumber swappingTwoNumber = new SwappingTwoNumber();
                    swappingTwoNumber.SwappingTwoNumbers();
                    break;
                
            }
        }
    }
}