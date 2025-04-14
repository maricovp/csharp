// Program.cs
using exercicio6.Modelo;

class Program
{
    static void Main(string[] args)
    {
        var jogo = EstadoDoJogo.Instancia;

        jogo.MostrarEstado();

        jogo.AdicionarPontos(100);
        jogo.PerderVida();
        jogo.AvancarNivel();

        jogo.MostrarEstado();

        // Teste do Singleton: pegar a instância de outro lugar e ver que é a mesma
        var outroAcesso = EstadoDoJogo.Instancia;
        outroAcesso.PerderVida();

        // Mostrar de novo pra ver que o estado é o mesmo
        jogo.MostrarEstado();
    }
}
