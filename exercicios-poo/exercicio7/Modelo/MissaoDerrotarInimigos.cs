using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7.Modelo
{
public class MissaoDerrotarInimigos : Missao
    {
        public int InimigosDerrotados;
        public int InimigosNecessarios;

        public MissaoDerrotarInimigos(int qtd) 
            : base("Derrotar Inimigos", $"Derrote {qtd} inimigos.")
        {
            InimigosNecessarios = qtd;
        }

        public override void Executar()
        {
            InimigosDerrotados = InimigosNecessarios; // simula
            Console.WriteLine($"Você derrotou {InimigosDerrotados} inimigos!");
            MarcarComoConcluida();
        }
    }
}