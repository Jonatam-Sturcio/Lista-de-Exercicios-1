namespace Exercicio24.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a tabuada na forma: 
                0 x N = 0, 
                1 x N = 1N, 
                2 x N = 2N,
                .
                .
                .  
                10 x N = 10N.
             */
            int n;
            Console.WriteLine("Informe um numero de 1 a 10 para calcular sua tabuada: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine($"{i} X {n} = {n*i}");
            }
        }
    }
}
