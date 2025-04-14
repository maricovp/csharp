using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio15.Modelo
{
public class Inimigo
    {
        public string Nome { get; private set; }
        private IEstado estadoAtual;

        public bool JogadorVisivel { get; set; }
        public int DistanciaParaJogador { get; set; }

        public Inimigo(string nome)
        {
            Nome = nome;
            estadoAtual = new EstadoPatrulha();
        }

        public void TrocarEstado(IEstado novoEstado)
        {
            estadoAtual = novoEstado;
        }

        public void Atualizar()
        {
            estadoAtual.Executar(this);
        }
    }
}