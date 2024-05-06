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
            string myAllFriends = "Teste";

            myFirstFriend = myFirstFriend.TrimStart();
            mySecondFriend = mySecondFriend.Trim();
            myThrirdFriend = myThrirdFriend.TrimEnd();
            myAllFriends = myAllFriends.ToUpper();

            Console.WriteLine($"{myFirstFriend} and {mySecondFriend} and {myThrirdFriend}");
            Console.WriteLine(myAllFriends);
        }
    }
}
