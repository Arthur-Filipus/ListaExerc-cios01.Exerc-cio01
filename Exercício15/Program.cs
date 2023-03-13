using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;

namespace Exercício15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler uma temperatura Celsius e imprima em Fahrenheit(pesquise como fazer este tipo de conversão).
            // F = C x 1,8 + 32

            Console.Write("Digite a temperatura em Celsius: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é de: {f}");

            Console.ReadLine();
        }
    }
}