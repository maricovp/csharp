using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio13.Modelo
{
public class Guerreiro : Carta
    {
        public Guerreiro(string nome) : base(nome, 100, 20) {}

        public override void Atacar(Carta alvo)
        {
            Console.WriteLine($"{Nome} (Guerreiro) golpeia com espada!");
            base.Atacar(alvo);
        }
    }
}