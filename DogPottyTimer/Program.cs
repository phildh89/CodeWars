using System;
using System.Threading;

namespace DogPottyTimer
{
    class Program
    {
        //timer start
        public static DateTime startTime;
        public static int poopCount = 0;
        public static int peeCount = 0;
        public static DateTime poopTime;
        public static DateTime peeTime;
        static void Main(string[] args)
        {
            startTime = DateTime.Now;
            Start();
        }

        public static void Start()
        {
            Console.Clear();

            //potty reset
            PottyReset();

            //restart timer and return time since last potty


            //timer
            Time();

            //restart
            Console.WriteLine("Restart? (y/n)");
            string restart = Console.ReadLine();
            if (restart == "y") Start();
        }
        
        public static void PottyReset()
        {
            Console.WriteLine("\tType of potty:\n\t\t1) Pee\n\t\t2) Poop\n\t\t3) Both");
            int input = Convert.ToInt32(Console.ReadLine());
            //add try catch

            if(input == 1 || input == 3)
            {
                peeCount++;
                peeTime = DateTime.Now;
            }
            if (input == 1 || input == 3)
            {
                poopCount++;
                poopTime = DateTime.Now;
            }


        }

        private static void Time()
        {
            double timeDiff = (DateTime.Now - startTime).TotalSeconds;
            int hour = Convert.ToInt32(timeDiff / 3600);
            int min = Convert.ToInt32((timeDiff % 3600) / 60);
            int sec = Convert.ToInt32((timeDiff % 3600) % 60);

            Console.WriteLine($"Time since last potty: {hour} hour(s) {min} minute(s) and {sec}seconds");
            startTime = DateTime.Now;
        }
    }
}
