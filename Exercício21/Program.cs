namespace Exercício21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.

            Console.Write("Digite o valor de A: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");

            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"A soma dos valores é de {a + b}");
            }
            else
            {
                Console.WriteLine($"A multiplicação dos valores é de {a * b}");
            }

            Console.ReadLine();
        }
    }
}