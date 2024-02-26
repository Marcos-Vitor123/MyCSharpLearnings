using System;

namespace Functions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite qualquer tecla direcional (ou 'S' para sair): ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(); // É armazenado na variável do tipo estrutura "ConsoleKeyInfo", informações do teclado

                if (keyInfo.Key == ConsoleKey.UpArrow) // A propriedade "Key" da estrutura "ConsoleKeyInfo", verifica qual tecla foi pressionada
                    Console.WriteLine("Para cima");
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                    Console.WriteLine("Para Baixo");
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    Console.WriteLine("Para esquerda");
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                    Console.WriteLine("Para direita");
                else if (keyInfo.Key == ConsoleKey.S)
                    break;
            }
        }
    }
}
