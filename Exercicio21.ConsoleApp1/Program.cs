namespace Exercicio21.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Faça um algoritmo que leia dois valores inteiros A e B, 
             * se os valores forem iguais deverá se somar os dois, caso 
             * contrário multiplique A por B. Ao final de qualquer um dos 
             * cálculos deve-se atribuir o resultado para uma variável C e 
             * mostrar seu conteúdo na tela.
             */

            int a, b, c;

            Console.WriteLine("Informe o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
                c = a + b;
            else
                c = a * b;

            Console.WriteLine($"O valor de C é: {c}");
        }
    }
}
