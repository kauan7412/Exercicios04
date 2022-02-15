using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = DateTime.Now.Hour;              
                if (x >= 6 && x <= 12 )
                {
                Console.WriteLine($"{x}");
                Console.WriteLine("bom dia!");
                }
                else if ( x <= 19)
                {
                Console.WriteLine($"{x}");
                Console.WriteLine("bom tarde!");
                }
                else 
                {
                Console.WriteLine($"{x}");
                Console.WriteLine("bom noite!");
                }
        }
    }
}
