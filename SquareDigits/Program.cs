using System;

namespace SquareDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SquareDigits.Program.Main()");
            Console.WriteLine(SquareDigits(9119));
        }
        public static int SquareDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }
    }
}
