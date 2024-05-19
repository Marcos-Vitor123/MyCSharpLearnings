using System;

namespace ConversaoImplicita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numerosCurto = 123;
            long numerosCurtoParaLongo = numerosCurto; // Conversão Implícita
            int numerosLongoParaCurto = (int)numerosCurtoParaLongo; // Conversão Explícita
        }
    }
}