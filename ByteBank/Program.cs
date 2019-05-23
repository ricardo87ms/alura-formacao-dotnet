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
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Ricardo Moreira Soares";
            funcionario.CPF = "123.456.789.78";
            funcionario.Salario = 1000;

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());
            Console.ReadKey();
        }
    }
}
