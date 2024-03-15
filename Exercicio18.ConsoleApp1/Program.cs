namespace Exercicio18.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Escreva um algoritmo que leia três valores inteiros e diferentes
            //e mostre-os em ordem decrescente.

            double n1, n2, n3, maior, menor, meio;

            Console.WriteLine("Informe o primeiro valor: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            n3 = Double.Parse(Console.ReadLine());


            maior = n1;
            if (n2 > maior) {
                maior = n2;
            }
            if (n3 > maior) {
                maior = n3;
            }

            menor = n1;
            if (n2 < menor) {
                menor = n2;
            }
            if (n3 < menor) {
                menor = n3;
            }

            meio = (n1 + n2 + n3) - (maior + menor);

            Console.WriteLine($"Ordem Decrescente: {maior},{meio},{menor}");
        }
    }
}
