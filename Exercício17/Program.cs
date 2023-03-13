namespace Exercício17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

            Console.Write("Digite o valor de A: ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C: ");

            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("O valor de A + B é menor que C");
            }

            Console.ReadLine();
        }
    }
}