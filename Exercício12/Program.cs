namespace Exercício12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
            //A=b⋅h

            Console.Write("Digite o tamanho da base do terreno: ");

            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o tamanho da altura do terreno: ");

            decimal h = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"A área do terreno é de: {b * h}");

            Console.ReadLine();
        }
    }
}