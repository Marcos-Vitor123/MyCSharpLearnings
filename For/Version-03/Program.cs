using System;

namespace For
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string asteristico = "*";
            Console.WriteLine($"******************************");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{asteristico}");
            }
            Console.WriteLine($"******************************");
        }
    }
}
