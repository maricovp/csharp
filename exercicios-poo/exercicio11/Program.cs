
using exercicio11.Modelo;

class Program
{
    static void Main(string[] args)
    {
        var jogador = new Personagem2D();

        jogador.MostrarStatus();

        jogador.AndarDireita();
        jogador.Pular();

        for (int i = 0; i < 20; i++) // simula 2 segundos de física (20x 0.1s)
        {
            jogador.AtualizarFisica();
            jogador.MostrarStatus();
            System.Threading.Thread.Sleep(100); // simula tempo real
        }

        jogador.AndarEsquerda();
        jogador.MostrarStatus();
    }
}
