namespace Exercicio9.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            string opcao = "";
            int qtd = 0;
            double soma = 0;

            do {
                Console.WriteLine("Informe a nota do aluno: ");
                soma += 1 / Double.Parse(Console.ReadLine());
                qtd++;
                Console.WriteLine("Deseja continuar adicionando notas? [s/n]");
                opcao = Console.ReadLine().ToLower();
                Console.Clear();
            } while (opcao != "n");
            Console.WriteLine($"A média harmonica do aluno é: {qtd / soma:F}");
        }
    }
}
