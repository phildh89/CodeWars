using System;
using System.Collections.Generic;

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Console.WriteLine(Kata.FriendOrFoe(names));
        }

    }
    public static class Kata
    {
            
            
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> listOfFriends = new List<string>();
            foreach (var item in names)
            {
                if (item.Length == 4)
                    listOfFriends.Add(item);
            }
            return listOfFriends;
        }
            
    }
}
