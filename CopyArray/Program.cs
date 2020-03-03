using System;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CopyArray.Program.Main()");
            CopyArray();
        }

        public static void CopyArray()
        {
            Console.Write("How many numbers are in your array: ");

            int indexNum = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[indexNum];
            

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}: ");
                input[i] += Convert.ToInt32(Console.ReadLine());
            }

            foreach (var k in input)
            {
                Console.Write(k);
            }
        }
    }
}
