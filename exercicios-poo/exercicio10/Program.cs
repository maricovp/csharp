// Program.cs
using exercicio10.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Mercado mercado = new Mercado();

        var joao = new Comerciante("João");
        var maria = new Comerciante("Maria");

        mercado.AdicionarObservador(joao);
        mercado.AdicionarObservador(maria);

        mercado.AtualizarPreco("Espada", 100);
        mercado.AtualizarPreco("Poção", 30);

        // Simular alta oferta de espadas => preço cai
        mercado.AtualizarPreco("Espada", 75);

        mercado.RemoverObservador(joao);

        // Agora só Maria será notificada
        mercado.AtualizarPreco("Poção", 20);
    }
}
