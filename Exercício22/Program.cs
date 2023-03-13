namespace Exercício22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

            Console.Write("Digite o valor de A: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");

            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            if (a == b)
            {
                c = a + b;
                
                Console.WriteLine($"A soma dos valores é de {c}");
            }
            else
            {
                c = a * b;
                
                Console.WriteLine($"A multiplicação dos valores é de {c}");
            }

            Console.ReadLine();
        }
    }
}