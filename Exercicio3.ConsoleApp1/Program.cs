namespace Exercicio3.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para calcular o volume de um Cilindro

            double raio, alt;
            const double pi = Math.PI;

            Console.WriteLine("Informe o Raio do cilindro:");
            raio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do cilindro:");
            alt = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume do cilindro é: {(pi*Math.Pow(raio,2)*alt):F}");
        }
    }
}
