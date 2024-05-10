namespace Coin_Flip_Gamba
{
    using static System.Console;
    internal class Program
    {
        public static int wager;
        public static int guess;
        public static int TossInt;
        public static int TossResult;
        public static char Continue = 'y';
        static void Main(string[] args)
        { 
            int balance = 5000;

            while (Continue == 'y')
            {
                WriteLine("Welcome to the coin toss! Please enter your wager!");
                WriteLine("Starting Balance: " + balance);
                wager = int.Parse(ReadLine());
                HeadOrTail();
                CoinToss();
                if (guess == TossResult)
                {
                    WriteLine("Congratulations! You have won " + wager + " points!");
                    balance = balance += wager;
                    WriteLine("Your new balance is: " + balance);
                }
                else
                {
                    WriteLine("Sorry! Better luck next time!");
                    balance = balance -= wager;
                    WriteLine("Your new balance is: " + balance);
                }
                Replay();

            }            
        }

        public static int HeadOrTail()
        {
            string headtail;
            WriteLine("Heads or Tails?");
            headtail = ReadLine().ToLower();
            if (headtail == "heads" || headtail == "head" || headtail == "h")
            {
                guess = 0;
            }
            else if (headtail == "tails" || headtail == "tail" || headtail == "t")
            {
                guess = 1;
            }
            return guess;
        }

        public static int CoinToss()
        {
            var rand = new Random();
            TossResult = rand.Next(2);
            return TossResult;
        }

        public static char Replay()
        {
            WriteLine("Would you like to play again? Y/N");
            Continue = char.Parse(ReadLine().ToLower());
            return Continue;
        }
    }
}
