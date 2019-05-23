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

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Ricardo Moreira Soares";
            funcionario.CPF = "123.456.789.78";
            funcionario.Salario = 1000;

            gerador.RegistrarFuncionario(funcionario);

            Diretor diretor = new Diretor();

            diretor.Nome = "Edivania Tatiele";
            diretor.CPF = "123.574.789.78";
            diretor.Salario = 5000;

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
