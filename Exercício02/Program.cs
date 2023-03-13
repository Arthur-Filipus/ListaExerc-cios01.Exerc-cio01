namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
            //(32 °F − 32) × 5/9 = 0 °C

            Console.Write("Digite a temperatura em Fahrenheit: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = 0;

            f = (c - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é de: {f}");

            Console.ReadLine();
        }
    }
}