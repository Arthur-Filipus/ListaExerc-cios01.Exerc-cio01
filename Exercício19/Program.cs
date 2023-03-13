namespace Exercício19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMC
            //IMC = peso / (altura)²

            Console.Write("Digite seu peso: ");

            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");

            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.Write("Você esta abaixo do Peso normal");
            }
            else if (imc > 18.5 && imc < 25)
            {
                Console.Write("Voce esta em Peso normal");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.Write("Você esta acima do Peso normal");
            }
            else if (imc > 30)
            {
                Console.Write("Você esta Obeso");
            }

            Console.ReadLine();
        }
    }
}