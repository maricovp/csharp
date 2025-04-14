using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio14.Modelo
{
public class NoDialogo
    {
        public string Texto;
        public List<Opcao> Opcoes = new List<Opcao>();

        public NoDialogo(string texto)
        {
            Texto = texto;
        }

        public void AdicionarOpcao(string textoOpcao, NoDialogo proximoNo)
        {
            Opcoes.Add(new Opcao(textoOpcao, proximoNo));
        }

        public bool TemOpcoes()
        {
            return Opcoes.Count > 0;
        }
    }

    public class Opcao
    {
        public string Texto;
        public NoDialogo Proximo;

        public Opcao(string texto, NoDialogo proximo)
        {
            Texto = texto;
            Proximo = proximo;
        }
    }
}