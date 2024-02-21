using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Mostrar();
        }

        public static string Mostrar()
        {
            Empresa minhaEmpresa = new("CEO", "Colaborador");

            Console.WriteLine($"Empresa: {minhaEmpresa.Presidente}\nFuncionário: {minhaEmpresa.Funcionario}");

            return $"Empresa: {minhaEmpresa.Presidente}\nFuncionário: {minhaEmpresa.Funcionario}";
        }
    }

    class Empresa
    {
        public string Presidente;
        public string Funcionario;

        public Empresa(string presidente, string funcionario)
        {
            Presidente = presidente;
            Funcionario = funcionario;
        }
    }
}
