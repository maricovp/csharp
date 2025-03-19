namespace Modelo
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Hp { get; set; }
        public int Ataque { get; set; }

        // Construtor
        public Personagem(string nome, int hp, int ataque)
        {
            Nome = nome;
            Hp = hp;
            Ataque = ataque;
        }

        // Método Atacar
        public void Atacar(Personagem alvo)
        {
            // Reduz o HP do adversário
            alvo.Hp -= Ataque;

            // Impede o HP de ser negativo
            if (alvo.Hp < 0)
                alvo.Hp = 0;

            // Exibe o dano causado e o HP restante do adversário
            Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {Ataque} de dano.");
            Console.WriteLine($"{alvo.Nome} agora tem {alvo.Hp} HP.");
        }

        // Método para exibir o status do personagem
        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome} | HP: {Hp}");
        }
    }
}