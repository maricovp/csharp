using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4.Modelo
{
public class PocaoVelocidade : Item
    {
        public PocaoVelocidade() : base("Poção de Velocidade") {}

        public override void Usar()
        {
            Console.WriteLine("Você usou uma Poção de Velocidade. Velocidade aumentada!");
        }
    }
}