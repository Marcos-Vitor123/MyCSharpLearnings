using System;

namespace forEach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int contador = 0;

            List<string> frutas = ["Maça", "Banana", "Abacaxi", "Pêra"];

            foreach (string fruta in frutas)
            {
                for (int i = 0; i < 1; i++)
                {
                    contador++;
                }
                Console.WriteLine($"{contador}° {fruta}");
            }
        }
    } 
}
