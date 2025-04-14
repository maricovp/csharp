// Program.cs
using exercicio9.Modelo;

class Program
{
    static void Main(string[] args)
    {
        var heroi = new Personagem("Elena");

        var slime = new Inimigo("Slime", 40);
        var lobo = new Inimigo("Lobo", 60);
        var dragao = new Inimigo("Dragão", 150);

        heroi.MostrarStatus();

        slime.DerrotadoPor(heroi);
        lobo.DerrotadoPor(heroi);
        heroi.MostrarStatus();

        dragao.DerrotadoPor(heroi);
        heroi.MostrarStatus();
    }
}
