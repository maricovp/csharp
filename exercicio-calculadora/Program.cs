using System;
using exercicio_calculadora.Modelo;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da calculadora
        Calculadora calc = new Calculadora();

        // Realizando operações
        double soma = calc.Somar(10, 5);
        double subtracao = calc.Subtrair(10, 5);
        double multiplicacao = calc.Multiplicar(10, 5);
        double divisao = calc.Dividir(10, 2);

        // Exibindo os resultados
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
        Console.WriteLine("Divisão: " + divisao);
    }
}
