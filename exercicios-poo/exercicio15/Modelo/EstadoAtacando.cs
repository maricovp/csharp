using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio15.Modelo
    {
    public class EstadoAtacando : IEstado
    {
        public void Executar(Inimigo inimigo)
        {
            Console.WriteLine($"{inimigo.Nome} ataca o jogador!");

            if (inimigo.DistanciaParaJogador > 1)
            {
                inimigo.TrocarEstado(new EstadoPerseguindo());
            }
        }
    }
}