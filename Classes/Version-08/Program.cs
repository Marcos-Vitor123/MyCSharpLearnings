using System;

namespace ClassePrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        public static bool NumeroPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }  

        public static void Menu() 
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (NumeroPrimo(numero))
                Console.WriteLine($"O número {numero} é primo.");
            else
                Console.WriteLine($"O número {numero} não é primo.");
        }
    }
}