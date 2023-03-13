namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível

            Console.Write("Digite a quilometragem inicial do percurso: ");

            double kminicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustivel inicial do percurso: ");

            double combustivelinicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem ao final do percurso: ");

            double kmfinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustivel ao final do percurso: ");

            double combustivelfinal = Convert.ToDouble(Console.ReadLine());

            double consumo = (kmfinal  - kminicial) / (combustivelinicial - combustivelfinal);

            Console.WriteLine($"Seu carro gastou {consumo} de Combustivel");

            Console.ReadLine();
        }
    }
}