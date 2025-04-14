using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
public class Arma : Item
    {
        public Arma() : base("Espada Flamejante") {}

        public override void Usar()
        {
            Console.WriteLine($"Você equipa a {Nome}. Ataque aumentado!");
        }
    }  
}