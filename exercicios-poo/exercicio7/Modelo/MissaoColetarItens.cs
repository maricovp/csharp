using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7.Modelo
{
public class MissaoColetarItens : Missao
    {
        public string Item;
        public int Quantidade;

        public MissaoColetarItens(string item, int qtd) 
            : base("Coletar Itens", $"Colete {qtd}x {item}.")
        {
            Item = item;
            Quantidade = qtd;
        }

        public override void Executar()
        {
            Console.WriteLine($"Você coletou {Quantidade}x {Item}!");
            MarcarComoConcluida();
        }
    }
}