using System;

namespace DoWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inicial = 0;
            int fim = 10;
            Console.WriteLine("Enquanto o número inicial for menor do que o número fim. A condição sempre será verdadeira e o programa continuará a executar.");

            do
            {
                Console.Write("Digite um número: ");
                int capturar = Convert.ToInt32(Console.ReadLine());
                inicial = capturar;

            } while(inicial < fim);

            Console.WriteLine($"Condição agora é falsa! Pois o número inicial {inicial} é menor do que o número fim {fim}.");
        }
    }
}