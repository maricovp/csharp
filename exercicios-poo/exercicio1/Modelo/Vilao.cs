using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1.Modelo
{
public class Vilao : NPC
    {
        public Vilao(string nome) : base(nome) {}

        public override void Mover()
        {
        Console.WriteLine($"{nome} está perseguindo o jogador!");
        }

        public override void Interagir()
        {
        Console.WriteLine($"{nome} ataca o jogador!");
        }
    }    
}