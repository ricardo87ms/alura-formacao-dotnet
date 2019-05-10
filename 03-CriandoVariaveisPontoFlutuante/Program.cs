using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis Double");

            double salario = 1250.50;
            Console.WriteLine(salario);

            double idade;

            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);

            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
