using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace primeiro
{
    class Retangulo
    {
        public double Largura , Altura;

        public static void ProgramaRetangulo()
        {
            
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine();
            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
        
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return Largura * 2 + Altura * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura* Altura));
        }

    }
}
