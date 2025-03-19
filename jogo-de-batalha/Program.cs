using System;
using Modelo;

class Program
{
    static void Main()
    {
        // Criando dois personagens
        Personagem jogador1 = new Personagem("Guerreiro", 100, 20);
        Personagem jogador2 = new Personagem("Mago", 80, 25);
        // Exibindo o status inicial
        jogador1.ExibirStatus();
        jogador2.ExibirStatus();
        // Iniciando o sistema de turnos
        bool jogoAtivo = true;
        while (jogoAtivo)
        {
            // Turno do jogador 1
            Console.WriteLine("\nTurno do Guerreiro!");
            jogador1.Atacar(jogador2);
            if (jogador2.Hp == 0)
            {
                Console.WriteLine($"{jogador2.Nome} foi derrotado! {jogador1.Nome} venceu!");
                jogoAtivo = false;
                break;
            }
            // Exibindo o status após o turno
            jogador1.ExibirStatus();
            jogador2.ExibirStatus();
            // Turno do jogador 2
            Console.WriteLine("\nTurno do Mago!");
            jogador2.Atacar(jogador1);
            if (jogador1.Hp == 0)
            {
                Console.WriteLine($"{jogador1.Nome} foi derrotado!{jogador2.Nome} venceu!");
                jogoAtivo = false;
                break;
            }
            // Exibindo o status após o turno
            jogador1.ExibirStatus();
            jogador2.ExibirStatus();
        }
        Console.WriteLine("Fim do jogo!");
    }
}
