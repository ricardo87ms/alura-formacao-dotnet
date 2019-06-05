using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerador = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario(1000, "123.456.789.78");

            funcionario.Nome = "Ricardo Moreira Soares";

            funcionario.AumentarSalario();
            Console.WriteLine("Salario do Ricardo: " + funcionario.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerador.RegistrarFuncionario(funcionario);

            Diretor diretor = new Diretor("123.574.789.78");

            diretor.Nome = "Edivania Tatiele";

            diretor.AumentarSalario();
            Console.WriteLine("Salario da Tatiele: " + diretor.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerador.RegistrarFuncionario(diretor);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());


            Console.WriteLine(gerador.GetTotalBonificacao());
            

            Console.ReadKey();
        }
    }
}
