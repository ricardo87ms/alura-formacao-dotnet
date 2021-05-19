using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario ricardo = new Funcionario(1000, "123.456.789-11");
            ricardo.Nome = "Ricardo";

            ricardo.AumentaSalario();

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(ricardo);

            Console.WriteLine(ricardo.Nome);
            Console.WriteLine("Salário :" +  ricardo.Salario);
            Console.WriteLine(ricardo.GetBonificacao());

            Diretor teste = new Diretor("123.456.789-22");
            teste.Nome = "Teste";

            teste.AumentaSalario();

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(teste);

            Console.WriteLine(teste.Nome);
            Console.WriteLine("Salário :" + teste.Salario);
            Console.WriteLine(teste.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadKey();
        }
    }
}
