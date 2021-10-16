using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace primeiro
{
    class Circulo
    {
        static double Pi = 3.14;

        public static void ProgramaCirculo()
        {
            Console.WriteLine("entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume : " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }
        static double Volume(double r)
        {
            return ((4.0 / 3.0) * Pi) * (r * r * r);
        }
    }
}
