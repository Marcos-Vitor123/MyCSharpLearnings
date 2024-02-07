using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.nome = "Havalão";
            animal.idade = 10;
            animal.especie = "Cavalo";
            animal.altura = 2.75f;
            animal.peso = 150f;

            Console.WriteLine($"Nome: {animal.nome}\nIdade: {animal.idade}\nEspécie: {animal.especie}\nAltura: {animal.altura}\nPeso: {animal.peso}");
        }
    }

    class Animal
    {
        public string nome { get; set; }
        public string especie { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }
        public int idade { get; set; }
    }
}