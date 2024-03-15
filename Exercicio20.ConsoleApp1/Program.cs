namespace Exercicio20.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
            int valor;
            Console.WriteLine("Informe um numero para verificar se é par ou impar: ");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
                Console.WriteLine($"{valor} é par");
            else
                Console.WriteLine($"{valor} é impar");
        }
    }
}
