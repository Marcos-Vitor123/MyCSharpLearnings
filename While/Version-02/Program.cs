using System;
using System.Threading;

namespace While
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int item = 0;
            int collection = 10;

            while(item < collection)
            {
                item++;
                Console.Clear();
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo finalizado!");
        }
    }
}