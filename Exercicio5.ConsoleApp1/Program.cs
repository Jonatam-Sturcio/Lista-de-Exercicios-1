namespace Exercicio5.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para calcular o volume de uma esfera
            double raio;
            const double pi = Math.PI;

            Console.WriteLine("Informe o raio da esfera:");
            raio = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume da esfera é: {((4 / 3) * pi * Math.Pow(raio, 3)):F}");
        }
    }
}
