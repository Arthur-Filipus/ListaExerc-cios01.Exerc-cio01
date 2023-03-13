using System;

namespace Exercício06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
            // F = C x 1,8 + 32

            Console.Write("Digite a temperatura em Celsius: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é de: {f}");

            Console.ReadLine();
        }
    }
}