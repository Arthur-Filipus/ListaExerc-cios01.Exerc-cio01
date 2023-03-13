namespace Exercício14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 (texto muy grande)

            Console.Write("Digite seu nome: ");

            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nome}, você já viveu {idade * 365} dias!");

            Console.ReadLine();
        }
    }
}