using System;

namespace Enumeradores
{
    internal class Program
    {
        enum EDiasDaSemana
        {
            Domingo = 1,
            Segunda = 2,
            Terça = 3,
            Quarta = 4,
            Quinta = 5,
            Sexta = 6,
            Sábado = 7
        }
        private static void Main(string[] args)
        {
            EDiasDaSemana diaDeHoje = EDiasDaSemana.Quinta;
            Console.WriteLine($"Hoje é: {diaDeHoje}");

            int diaNumero = (int)diaDeHoje;
            Console.WriteLine($"O Número equivalente a {diaDeHoje} é: {diaNumero}");
        }
    }
}