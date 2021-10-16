using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace primeiro
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int qtd)//construtor
        {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public Produto (string nome, double preco)//contrutor sobrecarga
        {
            _nome = nome;
            Preco = preco;
            Qtd = 5;

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd += quantidade;
        }

        public void RemoverProdutos (int quantidade)
        {
            Qtd -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtd
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }

        public static void ProgramaProdutos()//programa principal
        {


            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
