using System;
using Adivinhacao.Modelo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100. Tente adivinhar!");
        
        Jogo jogo = new Jogo();
        int palpite = 0;
        
        while (palpite != jogo.GetNumeroSecreto())
        {
            Console.Write("Digite seu palpite: ");
            
            // Verificando se o usuário digitou um número válido
            if (!int.TryParse(Console.ReadLine(), out palpite))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                continue;
            }

            string resultado = jogo.Adivinhar(palpite);
            Console.WriteLine(resultado);
        }
    }
}
