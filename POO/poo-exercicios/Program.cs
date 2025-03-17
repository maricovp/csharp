using System;

class Jogo
{
    private int numeroAleatorio;
    private int tentativas;
    
    public Jogo()
    {
        Random random = new Random();
        numeroAleatorio = random.Next(1, 101);  // Gera um número aleatório entre 1 e 100
        tentativas = 0;
    }

    public void Iniciar()
    {
        int palpite = 0;
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Eu escolhi um número entre 1 e 100. Tente adivinhar qual é!");

        while (palpite != numeroAleatorio)
        {
            Console.Write("Digite o seu palpite: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out palpite))
            {
                tentativas++;
                VerificarPalpite(palpite);
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }

    private void VerificarPalpite(int palpite)
    {
        if (palpite < numeroAleatorio)
        {
            Console.WriteLine("O número é maior que o seu palpite.");
        }
        else if (palpite > numeroAleatorio)
        {
            Console.WriteLine("O número é menor que o seu palpite.");
        }
        else
        {
            Console.WriteLine($"Parabéns! Você adivinhou o número {numeroAleatorio} em {tentativas} tentativas.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Cria uma nova instância do jogo e inicia
        Jogo jogo = new Jogo();
        jogo.Iniciar();
    }
}
