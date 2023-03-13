namespace Exercício09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média harmônica das notas de um Aluno
            //q / (1/n1) + (1/n2 + (1/n3) + (1/n4)...

            Console.Write("Quantidade de provas feitas: ");

            int quantidade = Convert.ToInt32(Console.ReadLine());

            decimal notatotal = 0;

            decimal media = 0;

            for (int i = quantidade; i > 0; i--)
            {
                Console.Write("Digite a nota do aluno: ");
                
                decimal nota = Convert.ToDecimal(Console.ReadLine());

                notatotal = notatotal + (1 / nota);
            }

            media = quantidade / notatotal;

            Console.WriteLine($"A média de notas foi de: {media}");
        }
    }
}