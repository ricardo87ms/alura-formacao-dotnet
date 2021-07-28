using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;

            this.CPF = cpf;
            this.Salario = salario;

            Console.WriteLine("Criando Funcionario!!!");
        }

        //public virtual void AumentaSalario()
        //{
        //Salario = Salario + (Salario * 0.1);
        //Salario = Salario * 1.1;
        //Salario *= 1.1;
        //}


        //public virtual double GetBonificacao()
        //{
        //    return this.Salario * 0.10;
        //}

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
