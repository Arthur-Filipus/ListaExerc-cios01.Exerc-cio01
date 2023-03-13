namespace Exercício29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //29 (texto longo)

            int resultado = 0;

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    resultado = i * j;

                    Console.WriteLine($"{i} x {j} = {resultado}");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}