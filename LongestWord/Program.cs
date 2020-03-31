using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestWord("the quick brown fox");
            Console.WriteLine();
            Test1("the quick brown fox");
        }

        public static void LongestWord(string input)
        {
            string[] inputSplit = input.Split(" ");
            int count = 0;

            for (int i = 0; i < inputSplit.Length; i++)
            {

                if (inputSplit[i].Length >= count)
                {
                    count = inputSplit[i].Length;
                }
            }

            Console.Write("The longest word(s) = ");

            for (int i = 0; i < inputSplit.Length; i++)
            {
                if (inputSplit[i].Length == count)
                {
                    Console.Write($"{inputSplit[i]} ");
                }
            }

        }

        public static void Test1(string input)
        {
            string[] words = input.Split(' ');
            string largestword = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > largestword.Length)
                {
                    largestword = words[i];
                }
            }
            Console.Write($"The largest word is {largestword}.");
        }
    }
}
