using System;

namespace forEach
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
