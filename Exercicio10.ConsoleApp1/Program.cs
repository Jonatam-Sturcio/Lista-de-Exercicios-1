namespace Exercicio10.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

            double peso1, peso2, nota1, nota2;

            Console.WriteLine("Informe a primeira nota:");
            nota1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso da primeira nota:");
            peso1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota:");
            nota2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso da segunda nota:");
            peso2 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A media ponderada do aluno é: " +
                $"{((peso1*nota1)+(peso2*nota2))/(peso1+peso2)}");
        }
    }
}
