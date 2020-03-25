using System;

namespace ReverseStringCase
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseCase();
        }
        public static void ReverseCase() 
        {
            Console.WriteLine("Enter a string:");
            string input = Convert.ToString(Console.ReadLine());
            string lowerInput = input.ToLower();
            string upperInput = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                if (lowerInput[i] == input[i])
                {
                    Console.Write(upperInput[i]);
                    continue;
                }
                Console.Write(lowerInput[i]);
            }
            
        }
    }
}
