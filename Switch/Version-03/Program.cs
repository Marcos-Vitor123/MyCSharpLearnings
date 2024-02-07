using System;

namespace Switch 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um número:");

            string input = Console.ReadLine();

            if (input != null)
            {
                if(int.TryParse(input, out int numero))
                {
                   switch(numero)
                    {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine($"Você digitou: {numero}");
                            break;
                        default:
                            Console.WriteLine($"Número inválido!");
                            break;
                    } 
                } else
                {
                    Console.WriteLine("Entrada inválida!");
                } 
            } else
            {
                Console.WriteLine("Entrada nula!");
            } 
        }
    }
}
