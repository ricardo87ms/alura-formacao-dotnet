using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaRicardo = new ContaCorrente();
            Console.WriteLine(contaRicardo.saldo);

            bool saque = contaRicardo.Sacar(500);
            Console.WriteLine(saque);

            Console.WriteLine(contaRicardo.saldo);

            contaRicardo.Depositar(500);
            Console.WriteLine(contaRicardo.saldo);

            saque = contaRicardo.Sacar(500);
            Console.WriteLine(saque);

            Console.WriteLine(contaRicardo.saldo);

            ContaCorrente contaTatiele = new ContaCorrente();
            contaTatiele.titular = "Tatiele";

            Console.WriteLine("Saldo Conta Ricardo: " + contaRicardo.saldo);
            Console.WriteLine("Saldo Conta Tatiele: " + contaTatiele.saldo);

            contaRicardo.Transferir(100, contaTatiele);

            Console.WriteLine("Saldo Conta Ricardo: " + contaRicardo.saldo);
            Console.WriteLine("Saldo Conta Tatiele: " + contaTatiele.saldo);

            Console.ReadLine();
        }
    }
}
