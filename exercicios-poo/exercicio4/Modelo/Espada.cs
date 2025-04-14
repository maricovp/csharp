using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4.Modelo
{
public class Espada : Item
    {
        public Espada() : base("Espada de Bronze") {}

        public override void Usar()
        {
            Console.WriteLine("Você equipou a Espada de Bronze. Dano aumentado!");
        }
    }
}