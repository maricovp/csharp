using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5.Modelo
{
public class Personagem
    {
        public string Nome;
        public int Mana;

        public Personagem(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }

        public void UsarHabilidade(Habilidade habilidade)
        {
            if (Mana >= habilidade.CustoDeMana)
            {
                Mana -= habilidade.CustoDeMana;
                Console.WriteLine($"{Nome} usou {habilidade.Nome}! (Mana restante: {Mana})");
                habilidade.Executar();
            }
            else
            {
                Console.WriteLine($"{Nome} não tem mana suficiente para usar {habilidade.Nome}!");
            }
        }
    }
}