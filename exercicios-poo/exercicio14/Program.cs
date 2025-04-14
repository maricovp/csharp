
using exercicio14.Modelo;

class Program
{
    static void Main(string[] args)
    {
        // Criando nós da árvore
        var inicio = new NoDialogo("Olá, aventureiro! O que deseja?");
        var comprar = new NoDialogo("Temos poções, espadas e armaduras.");
        var vender = new NoDialogo("O que você quer vender?");
        var sair = new NoDialogo("Até logo, volte sempre!");
        var fim = new NoDialogo("Fim da conversa.");

        // Ligando as opções (ramos da árvore)
        inicio.AdicionarOpcao("1. Comprar", comprar);
        inicio.AdicionarOpcao("2. Vender", vender);
        inicio.AdicionarOpcao("3. Sair", sair);

        comprar.AdicionarOpcao("1. Voltar", inicio);
        vender.AdicionarOpcao("1. Voltar", inicio);
        sair.AdicionarOpcao("1. Encerrar", fim);

        // Iniciando diálogo
        NoDialogo atual = inicio;

        while (atual != null)
        {
            Console.WriteLine("\nNPC: " + atual.Texto);

            if (!atual.TemOpcoes())
            {
                break;
            }

            for (int i = 0; i < atual.Opcoes.Count; i++)
            {
                Console.WriteLine(atual.Opcoes[i].Texto);
            }

            Console.Write("Escolha: ");
            string escolha = Console.ReadLine();

            int index;
            if (int.TryParse(escolha, out index) && index >= 1 && index <= atual.Opcoes.Count)
            {
                atual = atual.Opcoes[index - 1].Proximo;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        Console.WriteLine("\n[Diálogo encerrado]");
    }
}
