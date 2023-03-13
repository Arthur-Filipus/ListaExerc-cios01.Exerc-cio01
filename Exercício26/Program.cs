namespace Exercício26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //26 (texto longo)

            Console.Write("Digite um número para ser fatorado: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            int numerofinal = numero;

            Console.Write($"{numerofinal}! = {numerofinal}");

            for (int i = numero - 1; i > 1; i--)
            {
                Console.Write($" x {i} = ");

                numerofinal = numerofinal * i;

                Console.Write(numerofinal);
            }
            Console.WriteLine($"\nO fatorial de {numero} é {numerofinal} ");

            Console.ReadLine();
        }
    }
}