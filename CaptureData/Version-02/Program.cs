using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int capturar = Convert.ToInt32(Console.ReadLine()); // Coversão para inteiro, pois é padrão gerar string

            Console.WriteLine($"O número é: {capturar}");

            Console.ReadKey();
        }
    }
}