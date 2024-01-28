using System;

namespace ConversaoImplicita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte valorByte = 100;
            Console.WriteLine(valorByte);

            int valorInteiro = valorByte;
            Console.WriteLine(valorInteiro);

            char caractere = 'A';
            Console.WriteLine(caractere);

            int valorInt = caractere;
            Console.WriteLine(valorInteiro);
        }
    }
}