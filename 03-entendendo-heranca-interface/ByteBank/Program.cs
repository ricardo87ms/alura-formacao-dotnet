using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario ricardo = new Funcionario();
            ricardo.nome = "Ricardo";
            ricardo.CPF = "123.456.789-11";
            ricardo.Salario = 1000;

            gerenciador.Registrar(ricardo);

            Console.WriteLine(ricardo.GetBonificacao());

            Diretor teste = new Diretor();
            teste.Nome = "Teste";
            teste.CPF = "123.456.789-22";
            teste.Salario = 8000;

            gerenciador.Registrar(teste);

            Console.WriteLine(teste.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadKey();
        }
    }
}
