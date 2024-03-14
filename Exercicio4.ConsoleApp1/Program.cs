namespace Exercicio4.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Crie um programa para calcular o consumo de combustível por Km. 
             * Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo. 
             * Deverá ser informado o Consumo de Combustível
             */
            double kmInicial, kmFinal,combustivel;

            Console.WriteLine("Informe a quilometragem inicial:");
            kmInicial = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quilometragem final:");
            kmFinal = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o consumo de combustivel:");
            combustivel = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O consumo é de {((kmFinal-kmInicial) /combustivel):F} km/l");

        }
    }
}
