namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de um Cilindro
            //V = π.r2.h

            Console.Write("Digite o valor do Raio do cilindro: ");

            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da Altura do cilindro: ");

            double h = Convert.ToDouble(Console.ReadLine());

            double v = Math.PI * Math.Pow(r, 2) * h;

            Console.Write($"O volume do cilindro é de: {v}");

            Console.ReadLine();
        }
    }
}