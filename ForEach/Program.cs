using System;

namespace forEach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> frutas = new() {"Maça", "Banana", "Abacaxi", "Pêra"};
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}