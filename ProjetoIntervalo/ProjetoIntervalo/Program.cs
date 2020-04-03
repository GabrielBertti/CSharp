using System;
using System.Globalization;

namespace ProjetoIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor?");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0.0 || num >100.0)
            {
                Console.WriteLine("Fora de Intervalo");
                Console.ReadKey();
            }
            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0;25]");
                Console.ReadKey();
            }
            else if (num <= 50.0)
            {
                Console.WriteLine("Intervalo [25;50]");
                Console.ReadKey();
            }
            else if (num <= 75.0)
            {
                Console.WriteLine("Intervalo [50;75]");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Intervalo [75; 100]");
                Console.ReadKey();
            }
        }
    }
}
