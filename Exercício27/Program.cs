namespace Exercício27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
            //Fn = Fn - 1 + Fn - 2...

            Console.Write("Digite o número para a finalizar a sequencia: ");

            int final = Convert.ToInt32(Console.ReadLine());
            int numeroanterior = 0;
            int numeroatual = 1;
            int numerofinal = 0;

            for (int i = 1; numerofinal < final; i++)
            {
                numerofinal = numeroanterior + numeroatual;

                Console.Write($"{numerofinal} ");

                numeroanterior = numeroatual;

                numeroatual = numerofinal;

            }
            Console.ReadLine();
        }
    }
}