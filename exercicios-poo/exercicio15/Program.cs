
using exercicio15.Modelo;

class Program
{
    static void Main(string[] args)
    {
        var inimigo = new Inimigo("Goblin");

        // Simulação de mudanças de situação
        var passos = new (bool visivel, int distancia)[]
        {
            (false, 5), // patrulha
            (true, 3),  // começa a perseguir
            (true, 1),  // ataca
            (true, 2),  // volta a perseguir
            (false, 5), // volta a patrulhar
        };

        foreach (var passo in passos)
        {
            inimigo.JogadorVisivel = passo.visivel;
            inimigo.DistanciaParaJogador = passo.distancia;

            inimigo.Atualizar();
            Thread.Sleep(1000);
        }
    }
}
