namespace Exercicio6.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
            Console.WriteLine("Informe a temperatura em graus Celsius:");
            double celsius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A temperatura {celsius}c é equivalente a {(celsius *1.8 +32):F}f");
        }
    }
}
