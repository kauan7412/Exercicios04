using System;

namespace Diamantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a largura do retangulo");
            int Largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a altura do retangulo");
            int Altura = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Altura; i++)
            {
                Console.WriteLine();
                for (int A = 0; A < Largura;  A++)
                {
                    Console.Write("x");
                }
            }
        }
    }
}
