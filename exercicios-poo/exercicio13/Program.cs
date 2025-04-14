
using exercicio13.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Carta jogador1 = new Guerreiro("Thorin");
        Carta jogador2 = new Mago("Zyra");

        Console.WriteLine("=== Batalha Iniciada! ===\n");

        int turno = 1;
        while (jogador1.EstaViva() && jogador2.EstaViva())
        {
            Console.WriteLine($"\n--- Turno {turno} ---");

            if (turno % 2 == 1)
            {
                jogador1.Atacar(jogador2);
            }
            else
            {
                jogador2.Atacar(jogador1);
            }

            turno++;
            Thread.Sleep(1000);
        }

        Console.WriteLine("\n=== Fim da Batalha ===");
    }
}
