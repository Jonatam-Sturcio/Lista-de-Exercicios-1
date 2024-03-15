namespace Exercicio26.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Escreva um programa que leia um número e imprima a
            //sequência de Fibonacci até esse número.

            int i = 0, n, num, numA = 1, numB = 0;
            Console.WriteLine("Informe o valor para calcular sua sequencia de Fibonacci: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("A Sequencia de Fibonacci desse até esse numero é: ");

            while (i < n) {
                Console.Write($"{numA}, ");
                num = numA + numB;
                numB = numA;
                numA = num;
                i++;
            }
        }


    }
}
