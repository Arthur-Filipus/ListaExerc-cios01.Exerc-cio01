namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
            //Mp = [(N1 x P1) + (N2 x P2) + (N3 x P3)... ÷ (P1 + P2 + P3...).

            Console.Write("Quantidade de provas feitas: ");

            int quantidade = Convert.ToInt32(Console.ReadLine());
            
            decimal notatotal = 0;

            decimal pesototal = 0;
            
            for (int i = quantidade; i > 0; i--)
            {
                Console.Write("Digite a nota do aluno: ");

                decimal nota = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o peso da nota: ");

                decimal peso = Convert.ToDecimal(Console.ReadLine());

                notatotal = notatotal + (nota * peso);

                pesototal = pesototal + peso;
            }

            Console.WriteLine($"A Média Ponderada desse aluno é de: {notatotal / pesototal}");

            Console.ReadLine();
        }
    }
}