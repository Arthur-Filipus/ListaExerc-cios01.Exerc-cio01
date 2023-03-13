namespace Exercício23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

            for (int i = 100; i < 200; i++)
            {
                i++;
                
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}