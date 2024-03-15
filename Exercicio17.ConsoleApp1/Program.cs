namespace Exercicio17.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela
            //se a soma de A + B é menor que C.

            double a, b, c;

            Console.WriteLine("Informe o valor de A: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            c = Double.Parse(Console.ReadLine());

            if ((a + b) < c)
                Console.WriteLine("A soma de A + B é menor que C");
            else
                Console.WriteLine("A soma de A + B é maior que C");
        }
    }
}
