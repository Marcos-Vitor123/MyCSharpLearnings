using System;

namespace While 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inicial = 1;
            int final = 5;

            while(inicial < final)
            {
                Console.WriteLine(inicial);
                inicial++;
            }
        }
    }
}