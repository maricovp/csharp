using exercicio1.Modelo;

class Program
{
    static void Main(string[] args)
    {
        List<NPC> npcs = new List<NPC>()
        {
            new Vendedor("João"),
            new Guarda("Carlos"),
            new Vilao("Zorg")
        };

        foreach (var npc in npcs)
        {
            npc.Mover();
            npc.Interagir();
            Console.WriteLine();
        }
    }
}
