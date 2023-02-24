namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core program");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;
            }
        }
    }
}