using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1.Modelo
{
    
        public class Vendedor : NPC
    {
        public Vendedor(string nome) : base(nome) {}

        public override void Mover()
        {
        Console.WriteLine($"{nome} está andando pela loja.");
        }

        public override void Interagir()
        {
        Console.WriteLine($"{nome}: Quer comprar algo?");
        }
    }

    
}