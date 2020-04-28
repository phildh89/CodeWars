using System;
using System.Collections.Generic;

namespace DigitialRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitRoot(35165132));
        }
        public static int DigitRoot(long n)
        {
            Console.WriteLine(n);
            long result = 0;
            List<long> digitList = new List<long>(); 

            for (int i = 0; n != 0; i++)
            {
                long temp = (n % 10);
                n /= 10;
                digitList.Add(temp);
            }
            foreach (var x in digitList)
            {
                result += x;
            }
            if (result > 9)
            {
                result = DigitRoot(result);

            }
 
            return (int)result;
            
        }
    }
}
