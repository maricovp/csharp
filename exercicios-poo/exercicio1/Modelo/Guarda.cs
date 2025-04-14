using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1.Modelo
{

        public class Guarda : NPC
    {
        public Guarda(string nome) : base(nome) {}

        public override void Mover()
        {
        Console.WriteLine($"{nome} está patrulhando a área.");
        }

        public override void Interagir()
        {
        Console.WriteLine($"{nome}: Tudo certo por aqui.");
        }
    }

    
}