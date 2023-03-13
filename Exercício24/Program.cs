namespace Exercício24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

            int a = 0;

            for (int i = 0; i < 500; i++)
            {
                i++;
                if (i % 3 == 0 && i % 2 == 0)
                {
                    a = a + i;

                    Console.WriteLine(a);
                }

            }

            Console.ReadLine();
        }

    }
}