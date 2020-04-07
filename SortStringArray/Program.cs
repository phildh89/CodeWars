using System;

namespace SortStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SortString();
        }
        public static void SortString()
        {
            Console.Write("How many strings would you like in this array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string[] stringArr = new string[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter string #{i+1}");
                string input = Console.ReadLine();
                stringArr[i] = input.ToLower();
            }
            for (int i = 0; i < arraySize; i++)
            {
                for (int k = i+1; k < arraySize; k++)
                {
                    if(stringArr[i][0] > stringArr[k][0])
                    {
                        string temp = stringArr[i];
                        stringArr[i] = stringArr[k];
                        stringArr[k] = temp;

                    }
                }
            }
            Console.WriteLine("\nArray Sorted:");
            foreach (var s in stringArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
