using System;

namespace Foreach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> frutas = new List<string>() {"Maça", "Banana", "Abacaxi", "Pêra"}; // Forma antiga

            foreach (string fruta in frutas)
            {
                Console.WriteLine($"{fruta}");
            }
        }
    } 
}
