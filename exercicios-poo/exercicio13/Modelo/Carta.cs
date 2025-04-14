using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio13.Modelo
{
public abstract class Carta
    {
        public string Nome;
        public int Vida;
        public int Ataque;

        public Carta(string nome, int vida, int ataque)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
        }

        public virtual void Atacar(Carta alvo)
        {
            Console.WriteLine($"{Nome} ataca {alvo.Nome} com {Ataque} de dano!");
            alvo.ReceberDano(Ataque);
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida restante: {Vida}");

            if (Vida <= 0)
                Console.WriteLine($"{Nome} foi derrotado!");
        }

        public bool EstaViva()
        {
            return Vida > 0;
        }
    }
}