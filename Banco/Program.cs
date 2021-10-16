using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')
            {
                Console.Write("entre com o deposito inicial: ");
                double dinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome , numero, dinicial);

            }
            else
            {
                conta = new ContaBancaria(nome, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("dados da conta atualizados");
            Console.WriteLine(conta);
        }
    }
}
