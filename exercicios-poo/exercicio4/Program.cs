
using exercicio4.Modelo;

class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario(3);

        Item espada = new Espada();
        Item pocaoVida = new PocaoVida();
        Item pocaoVelocidade = new PocaoVelocidade();

        inventario.Adicionar(espada);
        inventario.Adicionar(pocaoVida);
        inventario.Adicionar(pocaoVelocidade);

        inventario.MostrarInventario();

        inventario.UsarItem("Poção de Vida");
        inventario.MostrarInventario();

        // Tentando adicionar mais um item além da capacidade
        inventario.Adicionar(new Espada());
    }
}
