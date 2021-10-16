using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public int Nconta { get; private set; }
        public double Saldo { get; private set; }
        public String Nome { get; set; }

        public ContaBancaria(string nome , int nconta)
        {
            Nconta = nconta;
            Nome = nome;
        }

        public ContaBancaria(string nome, int nconta, double saldo) : this(nome, nconta)
        {
            Saldo = saldo;

        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0) ;
        }

        public override string ToString()
        {
            return "Conta "
                + Nconta
                + ", Nome: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
