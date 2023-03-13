namespace Exercício16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.Imprima o salário inicial, o salário com o aumento e o salário final.

            Console.Write("Digite seu salário: ");

            double salarioinicial = Convert.ToDouble(Console.ReadLine());

            double salarioaumento = salarioinicial + 0.15 * salarioinicial;

            double salarioreduzido = salarioaumento - 0.08 * salarioaumento;

            Console.WriteLine($"Seu salário inicial é de R${salarioinicial}. \nSeu salário após o aumento fica em R${salarioaumento}. \nSeu salário após os impostos ficou em R${salarioreduzido}.");

            Console.ReadLine();
        }
    }
}