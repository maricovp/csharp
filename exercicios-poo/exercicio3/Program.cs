// Program.cs
using exercicio3.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Itens gerados aleatoriamente:\n");

        for (int i = 0; i < 5; i++)
        {
            Item item = ItemRandomizer.GerarItemAleatorio();
            Console.WriteLine($"Item: {item.Nome}");
            item.Usar();
            Console.WriteLine();
        }
    }
}
