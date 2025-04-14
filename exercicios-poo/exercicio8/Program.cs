// Program.cs
using exercicio8.Modelo;

class Program
{
    static void Main(string[] args)
    {
        var heroi = new Personagem("Lúcio");

        var espada = new Espada();
        var arco = new Arco();
        var couro = new ArmaduraDeCouro();
        var ferro = new ArmaduraDeFerro();

        heroi.MostrarStatus();

        heroi.TrocarArma(espada);
        heroi.TrocarArmadura(couro);

        heroi.MostrarStatus();

        heroi.TrocarArma(arco);
        heroi.TrocarArmadura(ferro);

        heroi.MostrarStatus();
    }
}