using System;

namespace IfElse 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Quer saber se o número é positivo ou negativo?\n");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Esse número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Esse número é negativo.");
            }
            else
            {
                Console.WriteLine("Esse número é neutro.");
            }
        }
    }
}