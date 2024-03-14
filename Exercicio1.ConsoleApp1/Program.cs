namespace Exercicio1.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para calcular o volume de uma caixa retangular

            double larg, comp, alt;

            Console.WriteLine("Informe o comprimento da caixa:");
            comp = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura da caixa:");
            larg = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da caixa:");
            alt = Double.Parse(Console.ReadLine());

            Console.WriteLine($"O volume da caixa é: {comp * larg * alt}");
        }
    }
}
