namespace Exercicio2.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

            Console.WriteLine("Informe a temperatura em graus Fahrenheit:");
            double fahr = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A temperatura {fahr}f é equivalente a {((fahr-32)/1.8):F}c");
        }
    }
}
