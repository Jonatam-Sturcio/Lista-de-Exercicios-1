namespace Exercicio13.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * A padaria Hotpão vende uma certa quantidade de pães franceses e 
             * uma quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12 e a 
             * broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com 
             * a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança 
             * (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. 
             * Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas,
             * e depois calcular os dados solicitados.
             */

            int qtdPao, qtdBroa;
            double arrecadado, poupanca;

            Console.WriteLine("Informe a quantidade de pães vendidos: ");
            qtdPao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de broas vendidas: ");
            qtdBroa = int.Parse(Console.ReadLine());

            arrecadado = qtdPao * 0.12 + qtdBroa * 1.5;
            poupanca = arrecadado * 0.1;

            Console.WriteLine($"Valor total arrecadado: R${arrecadado}");
            Console.WriteLine($"Valor a ser guardado na poupança: R${poupanca:F}");
        }
    }
}
