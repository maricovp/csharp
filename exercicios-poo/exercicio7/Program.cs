// Program.cs
using exercicio7.Modelo;

class Program
{
    static void Main(string[] args)
    {
        List<Missao> missoes = new List<Missao>()
        {
            new MissaoDerrotarInimigos(5),
            new MissaoColetarItens("Cristal Mágico", 3),
            new MissaoExplorar("Templo Perdido")
        };

        Console.WriteLine("Missões disponíveis:\n");

        foreach (var missao in missoes)
        {
            Console.WriteLine($"- {missao.Titulo}: {missao.Descricao}");
        }

        Console.WriteLine("\nExecutando missões...\n");

        foreach (var missao in missoes)
        {
            missao.Executar();
            Console.WriteLine();
        }
    }
}
