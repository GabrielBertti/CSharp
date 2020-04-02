using System;

namespace exercicioMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*leia 2 valores A B e informar se SÃO MUTIPLOS ou NAO */

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
                Console.ReadKey();
            }

        }
    }
}
