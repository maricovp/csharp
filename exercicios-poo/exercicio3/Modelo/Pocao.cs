using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
public class Pocao : Item
    {
        public Pocao() : base("Poção de Cura") {}

        public override void Usar()
        {
            Console.WriteLine($"Você usa a {Nome}. Vida restaurada!");
        }
    }
}