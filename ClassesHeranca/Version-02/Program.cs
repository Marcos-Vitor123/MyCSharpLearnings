using System;

namespace ClassesHeranca
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Instância
            Animal animal = new("Cachorro", 10);

            // Defini a propriedade
            animal.Nome = "Animal";
            animal.Idade = 10;

            // Acessa o método
            animal.EmitirSom();

            Console.WriteLine($"Um animal tem como característica: {animal.Nome}");
        }
    }

    // Classe Base
    public class Animal
    {
        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Animal (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Métodos
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de um animal qualquer");
        }
    }
}