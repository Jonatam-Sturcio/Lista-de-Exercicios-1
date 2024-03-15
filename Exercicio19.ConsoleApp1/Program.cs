﻿namespace Exercicio19.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para 
             * dar uma indicação sobre a condição de peso de uma pessoa adulta.
             * A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o peso e
             * a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
                IMC em adultos Condição
                Abaixo de 18,5
                Abaixo do peso
                Entre 18,5 e 25 Peso normal
                Entre 25 e 30
                Acima do peso
                Acima de 30 obeso
             */
            double imc, peso, altura;
            Console.WriteLine("Informe seu peso: ");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura: ");
            altura = Double.Parse(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
                Console.WriteLine($"IMC: {imc:F} -> Abaixo do Peso");
            else if(imc >=18.5 && imc <25)
                Console.WriteLine($"IMC: {imc:F} -> Peso normal");
            else if (imc >= 25 && imc < 30)
                Console.WriteLine($"IMC: {imc:F} -> Acima do Peso");
            else
                Console.WriteLine($"IMC: {imc:F} -> Obeso");
        }
    }
}
