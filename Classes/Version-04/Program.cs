﻿using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pessoa pessoa = new("Marcos", 34);
            Pessoa pessoa2 = new("Maria", 25);
            
            Console.WriteLine($"Nome: {pessoa.Name}\nIdade: {pessoa.Age}");
            Console.WriteLine($"Nome: {pessoa2.Name}\nIdade: {pessoa2.Age}");
        }
    }

    class Pessoa 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pessoa(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
