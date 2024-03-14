namespace Exercicio7.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Crie um programa para calcular o salário total de um vendedor. 
             * Deverá ser informado o salário base e o total de vendas. 
             * A comissão é calculada com um percentual (informado pelo usuário)
             * sobre o total de vendas.
             */
            double salBase, vendas, comissao;

            Console.WriteLine("Informe o salário base:");
            salBase = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas:");
            vendas = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua comissao:");
            comissao = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O salário total é de: R$ {(salBase+(vendas*comissao/100)):F}");
        }
    }
}
