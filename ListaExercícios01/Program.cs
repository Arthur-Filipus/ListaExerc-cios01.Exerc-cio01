namespace ListaExercícios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma caixa retangular
            //O cálculo do volume é sempre dado pela multiplicação da altura (h), vezes a largura (L), vezes o comprimento (C).

            Console.Write("Digite o valor da Base: ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da Altura: ");

            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do Comprimento: ");

            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O Volume da sua caixa é de: {b * h * c}");

            Console.ReadLine();
        }
    }
}