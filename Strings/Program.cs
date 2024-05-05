using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstFriend = "             Marcos          ";
            string mySecondFriend = "       Maria                 ";

            myFirstFriend = myFirstFriend.TrimStart();
            mySecondFriend = mySecondFriend.Trim();

            Console.WriteLine($"{myFirstFriend} and {mySecondFriend}");
        }
    }
}
