using ExemplosApp.Console.Models;
using System;

namespace ExemplosAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu APP\n\n");

            var idade = 18;
            var nomePessoa = "Lucas";
            var nomeDaMae = "Joana";
            var idadeDaMae = 40;

            Console.WriteLine(string.Format("Nome: {0} - Idade: {1} / Mãe: {2} - Idade: {3}", nomePessoa, idade, nomeDaMae, idadeDaMae));

            var pessoa = new Pessoa() { Cpf = "000.000.000-00", Nome = "Nome", Sobrenome = "Sobrenome" };
            pessoa.Telefones = new System.Collections.Generic.List<Telefone>();
            AdicionarTelefone(pessoa, "+55 51 3333-4444");
            AdicionarTelefone(pessoa, "+55 51 4444-5555");
            AdicionarTelefone(pessoa, "+55 51 5555-6666");

            foreach(var telefone in pessoa.Telefones)
            {
                Console.WriteLine($"Telefone: {telefone.Numero}");
            }
        }

        private static void AdicionarTelefone(Pessoa pessoa, string numero)
        {
            pessoa.Telefones.Add(new Telefone { Numero = numero });
        }
    }
}
