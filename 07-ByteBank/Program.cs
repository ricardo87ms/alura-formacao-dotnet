﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(879, 8898977);

            //conta.Agencia = 879;
            //conta.Numero = 8898977;

            //conta.Agencia = -10;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            ContaCorrente contaRicardo = new ContaCorrente(879, 8898988);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadKey();
        }
    }
}
