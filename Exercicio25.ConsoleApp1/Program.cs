namespace Exercicio25.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Escreva um algoritmo que leia um valor inicial A e imprima a 
             * sequência de valores do cálculo de A! e o seu resultado.
                Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120

             */
            int a;
            double soma = 1;
            Console.WriteLine("Informe o valor inicial: ");
            a = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--) {
                soma *= i;
            }
            Console.WriteLine($"O valor de !{a} é: {soma}");
        }
    }
}
