
using exercicio12.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Reacoes reacoes = new Reacoes();

        // Inscrevendo métodos nos eventos
        EventosDoJogo.ChefeDerrotado += reacoes.AbrirNovaArea;
        EventosDoJogo.JogadorSubiuNivel += reacoes.TocarMusicaVitoria;
        EventosDoJogo.MissaoConcluida += reacoes.MostrarCutscene;

        // Simulando eventos do jogo
        EventosDoJogo.DispararChefeDerrotado();
        EventosDoJogo.DispararJogadorSubiuNivel();
        EventosDoJogo.DispararMissaoConcluida();
    }
}
