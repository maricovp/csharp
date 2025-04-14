using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4.Modelo
{
public class PocaoVida : Item
    {
        public PocaoVida() : base("Poção de Vida") {}

        public override void Usar()
        {
            Console.WriteLine("Você usou uma Poção de Vida. Vida restaurada!");
        }
    }
}