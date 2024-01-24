using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string capturar = Console.ReadLine();
            Console.WriteLine($"Olá, {capturar}");

            Console.ReadKey();
        }
    }
}
