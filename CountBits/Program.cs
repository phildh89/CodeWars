using System;

namespace CountBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234));
        }
        public static int CountBits(int input)
        {
            string bit = "";
            int count = 0;
            int binCount = 0;
            for (int i = 0; Math.Pow(2, i) <= input; i++)
            {
                binCount++;
            }

            int exponent = binCount - 1;
            for (int i = binCount; i > 0; i--)
            {
                if (Math.Pow(2, exponent) <= input)
                {
                    input -= Convert.ToInt32(Math.Pow(2, exponent));
                    bit += 1;
                    exponent--;
                    count++;
                    continue;
                }
                bit += 0;
                exponent--;
            }

            return count;
        }
    }
}
