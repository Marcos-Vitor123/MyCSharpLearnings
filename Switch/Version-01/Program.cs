﻿using System;

namespace Switch 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            switch(numero)
            {
                case 1:
                    Console.WriteLine($"Você digitou: {numero}");
                    break;
                case 2:
                    Console.WriteLine($"Você digitou: {numero}");
                    break;
                case 3:
                    Console.WriteLine($"Você digitou: {numero}");
                    break;
                default:
                    Console.WriteLine($"Número inválido!");
                    break;
            }
        }
    }
}
