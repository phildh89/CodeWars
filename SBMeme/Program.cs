using System;

namespace SBMeme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SBMeme.Program.Main()");

            Console.WriteLine(Meme("i am big brain. i have big pee pee"));
        }

        public static string Meme(string inputPhrase)
        {
            string memeString = "";
            for (int i = 0; i < inputPhrase.Length; i++)
            {
                if (i % 2 == 1)
                {
                    inputPhrase = inputPhrase.ToUpper();
                    memeString += inputPhrase[i];
                }
                if (i % 2 == 0)
                {
                    inputPhrase = inputPhrase.ToLower();
                    memeString += inputPhrase[i];
                }
            }
            return memeString;
        }
    }
}
