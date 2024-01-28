using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numeroInteiro = 10;
            Console.WriteLine(numeroInteiro);
            double numeroDouble = (double)numeroInteiro;
            Console.WriteLine(numeroDouble);

            double numeroDouble2 = 10.5;
            Console.WriteLine(numeroDouble2);
            int numeroInteiro2 = (int)numeroDouble2;
            Console.WriteLine(numeroInteiro2);

            char caractere = 'A';
            Console.WriteLine(caractere);
            int codigoASCII = (int)caractere;
            Console.WriteLine(codigoASCII);
        }
    }
}