using System;
using System.Globalization;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            Console.WriteLine("Escolha o Programa");
            Console.WriteLine("1 = Programa de produtos");
            Console.WriteLine("2 = Programa Retangulo" );
            Console.WriteLine("3 = Programa Circulo");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {

                Produto.ProgramaProdutos();
            }
            else if (escolha == 2)
            {
                Retangulo.ProgramaRetangulo();
            }
            else if (escolha == 3)
            {
                Circulo.ProgramaCirculo();
            }
            else
            {
                
            }
        }
    }
}
