using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5.Modelo
{
public class GolpeDeEspada : Habilidade
    {
        public GolpeDeEspada() : base("Golpe de Espada", 5, 12) {}

        public override void Executar()
        {
            Console.WriteLine($"Você desferiu um {Nome} causando {Dano} de dano!");
        }
    }
}