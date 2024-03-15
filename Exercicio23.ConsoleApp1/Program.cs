namespace Exercicio23.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Desenvolver um algoritmo que efetue a soma de todos os números
            //ímpares que são múltiplos de três e que se encontram no conjunto
            //dos números de 1 até 500.

            int soma = 0;
            for (int i = 0; i < 500; i+=3) {
                if (i % 2 != 0 )
                    soma += i;
            }
            Console.WriteLine($"A soma dos numeros é: {soma}");
        }
    }
}
