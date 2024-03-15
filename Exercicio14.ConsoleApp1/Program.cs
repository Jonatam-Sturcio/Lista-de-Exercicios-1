namespace Exercicio14.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Escreva um algoritmo para ler o nome e a idade de uma pessoa, 
             * e exibir quantos dias de vida ela possui. Considere sempre anos completos, 
             * e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 
             * dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
            */

            int idade;
            string nome;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, você já viveu {idade*365} dias");
        }
    }
}
