using System;

namespace For
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero + 1; i++)
            {
                Console.WriteLine($"Número: {i}");
            }
        }
    }
}
