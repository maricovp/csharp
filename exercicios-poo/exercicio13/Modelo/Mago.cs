using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio13.Modelo
{
public class Mago : Carta
    {
        public Mago(string nome) : base(nome, 70, 30) {}

        public override void Atacar(Carta alvo)
        {
            Console.WriteLine($"{Nome} (Mago) lança uma bola de fogo!");
            base.Atacar(alvo);
        }
    }
}