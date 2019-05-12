using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaRicardo = new ContaCorrente();
            contaRicardo.titular = "Ricardo";
            contaRicardo.numeroAgencia = 8898;
            contaRicardo.numero = 454212121;

            ContaCorrente contaRicardoMoreira = new ContaCorrente();
            contaRicardoMoreira.titular = "Ricardo";
            contaRicardoMoreira.numeroAgencia = 8898;
            contaRicardoMoreira.numero = 454212121;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaRicardo == contaRicardoMoreira));

            int idade = 31;
            int idadeNovamente = 31;

            Console.WriteLine(idade == idadeNovamente);

            contaRicardo = contaRicardoMoreira;

            Console.WriteLine("Igualdade de tipo de valor: " + (contaRicardo == contaRicardoMoreira));

            contaRicardoMoreira.saldo = 300;
            Console.WriteLine(contaRicardo.saldo);
            Console.WriteLine(contaRicardoMoreira.saldo);

            Console.ReadLine();
        }
    }
}
