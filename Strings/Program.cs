using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstFriend = "             Marcos          ";
            string mySecondFriend = "       Maria                 ";
            string myThrirdFriend = "       João                  ";

            myFirstFriend = myFirstFriend.TrimStart();
            mySecondFriend = mySecondFriend.Trim();
            myThrirdFriend = myThrirdFriend.TrimEnd();

            Console.WriteLine($"{myFirstFriend} and {mySecondFriend} and {myThrirdFriend}");
        }
    }
}
