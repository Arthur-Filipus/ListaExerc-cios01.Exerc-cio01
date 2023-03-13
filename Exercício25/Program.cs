namespace Exercício25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //25 (texto longo)
            bool a = true;
            do
            {
                Console.Write("Digite um valor de 1 a 10: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 10 && n < 1)
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                    continue;
                }
                else
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine($"{i} x {n} = {i * n}");
                    }
                }
                a = false;
            }while (a == true);

            Console.ReadLine();
        }
    }
}