using System;

namespace Accumul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("Hello World!"));
        }
        public static string Accum(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                result += char.ToUpper(s[i]);
                for (int k = i; k > 0; k--)
                {
                    result += char.ToLower(s[i]);
                }
                if (i != s.Length - 1)
                {
                    result += "-";
                }

            }
            return result;
        }
    }
}
