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
        }
    }
}
