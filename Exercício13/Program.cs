namespace Exercício13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 (texto longo demais)

            Console.Write("Digite a quantidade de pães vendidos: ");

            double pao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");

            double broa = Convert.ToDouble(Console.ReadLine());

            double precopao = 0.12;

            double precobroa = 1.50;

            double total = precopao * pao + broa * precobroa;

            double poupança = 0.1 * total;

            Console.WriteLine($"Foi arrecadado um total de R${total}. \nE pode ser guardado um total de R${poupança}.");

            Console.ReadLine();
        }
    }
}