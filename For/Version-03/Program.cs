using System;

namespace For
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string asteristico = "*";

            for (int i = 10; i >= 1; i--)
            {
                for (int m = 0; m <= 11; m++)
                {
                    Console.WriteLine($"{asteristico}");
                    Console.Write(" ");
                }


                for (int n = 0; n <= 11; n++)
                {
                    Console.WriteLine($"{asteristico}");
                }
            }
        }
    }
}
