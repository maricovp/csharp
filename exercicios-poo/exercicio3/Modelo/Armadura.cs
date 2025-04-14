using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
public class Armadura : Item
    {
        public Armadura() : base("Armadura de Aço") {}

        public override void Usar()
        {
            Console.WriteLine($"Você veste a {Nome}. Defesa aumentada!");
        }
    } 
}