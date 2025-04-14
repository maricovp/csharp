
using exercicio5.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Personagem heroi = new Personagem("Arthus", 20);

        Habilidade bolaDeFogo = new BolaDeFogo();
        Habilidade raioDeGelo = new RaioDeGelo();
        Habilidade golpeDeEspada = new GolpeDeEspada();

        heroi.UsarHabilidade(bolaDeFogo);
        heroi.UsarHabilidade(raioDeGelo);
        heroi.UsarHabilidade(golpeDeEspada); // Essa deve falhar se mana tiver acabado
    }
}
