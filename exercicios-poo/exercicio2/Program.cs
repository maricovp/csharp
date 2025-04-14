// Program.cs
using exercicio2.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Inimigo inimigo = new Inimigo("Goblin", 50);

        List<IAtacante> atacantes = new List<IAtacante>()
        {
            new Guerreiro(),
            new Mago(),
            new Arqueiro()
        };

        foreach (var atacante in atacantes)
        {
            atacante.Atacar(inimigo);
            Console.WriteLine();
        }

        if (!inimigo.EstaVivo())
            Console.WriteLine($"{inimigo.Nome} foi derrotado!");
        else
            Console.WriteLine($"{inimigo.Nome} ainda está vivo com {inimigo.Vida} de vida.");
    }
}