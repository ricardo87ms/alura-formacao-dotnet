using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
            CPF = CPF;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
