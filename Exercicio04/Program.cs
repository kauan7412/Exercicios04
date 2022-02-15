using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int numeron = 0;
            int numerop = 0;
            int resultante;
            int soma = 0;
            for (int i = 0; i <numeros.Length; i++)
            {
                Console.WriteLine("digite o valor");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    numeron++;
                }
                else
                {
                    numerop++;
                }

            soma += numeros[i];
            }
            resultante = soma / 5;
            Console.WriteLine($"A Media Arimétrica é {resultante}");
            Console.WriteLine($"A quantidade de valores positivos é :{numerop}");
            Console.WriteLine($"A quantidade de valores negativos é :{numeron}");
        }
    }
}
