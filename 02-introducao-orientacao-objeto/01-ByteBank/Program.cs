using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaTatiele = new ContaCorrente();
            contaDaTatiele.titular = "Tatiele";
            contaDaTatiele.numeroAgencia = 862;
            contaDaTatiele.numero = 1132087;
            contaDaTatiele.saldo = 100;

            Console.WriteLine(contaDaTatiele.titular);
            Console.WriteLine("Agência: " + contaDaTatiele.numeroAgencia);
            Console.WriteLine("Número: " + contaDaTatiele.numero);
            Console.WriteLine("Saldo: " + contaDaTatiele.saldo);

            Console.ReadLine();
        }
    }
}
