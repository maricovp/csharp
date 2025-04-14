using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio13.Modelo
{
public class Assassino : Carta
    {
        public Assassino(string nome) : base(nome, 60, 40) {}

        public override void Atacar(Carta alvo)
        {
            Console.WriteLine($"{Nome} (Assassino) realiza ataque furtivo!");
            base.Atacar(alvo);
        }
    }
}