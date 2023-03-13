namespace Exercício07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

            Console.Write("Digite seu salário base: ");

            double s = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu total de vendas: ");

            double v = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a comissão por venda: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double t = s + (v * c);

            Console.WriteLine($"Seu salário total é de: R${t}");

            Console.ReadLine();
        }
    }
}