using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5.Modelo
{
public class BolaDeFogo : Habilidade
    {
        public BolaDeFogo() : base("Bola de Fogo", 10, 25) {}

        public override void Executar()
        {
            Console.WriteLine($"Você lança uma {Nome} causando {Dano} de dano!");
        }
    }
}