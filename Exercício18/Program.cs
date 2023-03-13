using System;

namespace Exercício18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

            bool teste = true;
            
            do
            {
                Console.Write("Digite o valor inteiro de A: ");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor inteiro de B: ");

                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor inteiro de C: ");

                int c = Convert.ToInt32(Console.ReadLine());

                if (a != b && a != c && b != c)
                {
                    if (a > b && a > c && b > c)
                    {
                        Console.Write($"A ordem decressente dos valores é: {a} {b} {c}");
                    }
                    else if (a > b && a > c && c > b)
                    {
                        Console.Write($"A ordem decressente dos valores é: {a} {c} {b}");
                    }
                    else if (b > a && b > c && a > c)
                    {
                        Console.Write($"A ordem decressente dos valores é: {b} {a} {c}");
                    }
                    else if (b > a && b > c && c > a)
                    {
                        Console.Write($"A ordem decressente dos valores é: {b} {c} {a}");
                    }
                    else if (c > a && c > b && a > b)
                    {
                        Console.Write($"A ordem decressente dos valores é: {c} {a} {b}");
                    }
                    else if (c > a && c > b && b > a)
                    {
                        Console.Write($"A ordem decressente dos valores é: {c} {b} {a}");
                    }
                }
                else
                {
                    Console.WriteLine("Um dos valores é igual a outro, tente novamente.");
                    continue;
                }
                
                teste = false;
            } while (teste);

            Console.ReadLine();
        }
    }
}