using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario 
    {
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor!!!");
        }
    }
}
