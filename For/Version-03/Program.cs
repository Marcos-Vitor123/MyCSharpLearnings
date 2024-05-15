using System;

namespace For
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string asteristico = "*";

            int m = 0;
            while (m < 31)
            {
                Console.WriteLine($"{asteristico}");
                m++;
            }

            for (int i = 10; i >= 1; i--)
            {
                int n = 0;
                while (n < 29)
                {
                    //Console.WriteLine($"{asteristico}");
                    Console.Write(" ");
                    //Console.WriteLine($"{asteristico}");
                    n++;
                }
            }

            int o = 0;
            while (o < 31)
            {
                Console.WriteLine($"{asteristico}");
                o++;
            }
        }
    }
}
