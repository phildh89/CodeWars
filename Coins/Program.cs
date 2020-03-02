using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coins.Program.Main()");

            CoinCount(121.37);
        }
        public static void CoinCount(double input)
        {
            int centAmount = Convert.ToInt32(input*100);
            int quarters = centAmount / 25;
            centAmount = centAmount % 25;

            int dimes = centAmount / 10;
            centAmount = centAmount % 10;

            int nickles = centAmount / 5;
            int pennies = centAmount % 5;

             

            Console.WriteLine($"Quarters: {quarters}\nDimes: {dimes}\nNickles:{nickles}\nPennies:{pennies}");

        }
    }
}
