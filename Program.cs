namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core program");
            Console.WriteLine("1.FlipCoin\n2:Leap Year\n3:PowerOfTwo\n4:Harmonics\n5:FindQuotient\n6:SwappingTwoNumber\n7:EvenOrOdd\n8:ConsonantVowel\n9:LargestNumber\n10:Factors");
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
                case 7:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.FindEvenOrOdd();
                    break;
                case 8:
                    ConsonantVowel consonantVowel = new ConsonantVowel();
                    consonantVowel.ConsonantOrVowel();
                    break;
                case 9:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.LargestOfThreeNumber();
                    break;
                case 10:
                    Factors factors = new Factors();
                    factors.FactorsNumber();
                    break;

            }
        }
    }
}