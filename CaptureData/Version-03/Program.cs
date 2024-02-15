using System;

namespace CaptureData
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            char capturar = Convert.ToChar(Console.ReadLine()); 

            Console.WriteLine($"O número é: {capturar}");

            Console.ReadKey();
        }
    }
}
