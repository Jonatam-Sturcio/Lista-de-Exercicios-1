namespace Exercicio12.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            double comprimento, largura;

            Console.WriteLine("Informe a largura do terreno: ");
            largura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o comprimento do terreno: ");
            comprimento = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A area do terreno é: {comprimento*largura}m quadrados");
        }
    }
}
