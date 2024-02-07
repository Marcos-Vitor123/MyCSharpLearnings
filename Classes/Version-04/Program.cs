using System;

namespace Classes 
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
        public string Name;
        public int Age;
        public Pessoa(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
