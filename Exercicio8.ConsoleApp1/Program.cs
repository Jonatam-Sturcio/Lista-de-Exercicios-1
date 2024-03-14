namespace Exercicio8.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para calcular o volume de uma lata de óleo

            double raio, alt;
            const double pi = Math.PI;

            Console.WriteLine("Informe o Raio da lata de óleo:");
            raio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da lata de óleo:");
            alt = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume da lata de óleo é: {(pi * Math.Pow(raio, 2) * alt):F}");
        }
    }
}
