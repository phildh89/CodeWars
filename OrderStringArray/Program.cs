using System;

namespace OrderStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OrderStringArray.Program.Main()");

            Console.WriteLine(OrderString("I like to eat apples and bananas"));
        }
        public static string OrderString(string input)
        {
            string[] arrString = input.Split(" ");
            string result = "";
            int temp = 0;
            for (int charCount = 1;temp !=arrString.Length ; charCount++)
            {
                for (int stringCount = 0; stringCount < arrString.Length; stringCount++) //counts array string
                {
                    if (arrString[stringCount].Length == charCount)
                    {
                        result += arrString[stringCount] + " ";
                        temp++;
                    }
                   
                }
            }


            return result;
        }
    }
}
