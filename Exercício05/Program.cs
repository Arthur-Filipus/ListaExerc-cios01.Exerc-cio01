namespace Exercício05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma esfera
            //V = 4 / 3. p.r³

            Console.Write("Digite o raio da esfera: ");

            double r = Convert.ToDouble(Console.ReadLine());

            double v = 4 * Math.PI * Math.Pow(r, 3) / 3;
            
            Console.WriteLine($"O raio da esfera é de {v}³");

            Console.ReadLine();
        }
    }
}