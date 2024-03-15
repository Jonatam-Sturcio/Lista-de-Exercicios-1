namespace Exercicio16.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Faça um algoritmo para ler o salário de um funcionário e 
             * aumentá-lo em 15%. Após o aumento, desconte 8% de impostos. 
             * Imprima o salário inicial, o salário com o aumento e o salário final.
             */
            double salario;

            Console.WriteLine("Informe o salário atual: ");
            salario = Double.Parse(Console.ReadLine());

            salario = salario * 1.15;

            Console.WriteLine($"Valor do salário com aumento de 15%: R${salario:F}");

            salario = salario * 0.92;

            Console.WriteLine($"Valor do salário com desconto de 8%: R${salario:F}");
        }
    }
}
