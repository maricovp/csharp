using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7.Modelo
{
public class MissaoExplorar : Missao
    {
        public string Local;

        public MissaoExplorar(string local) 
            : base("Explorar Área", $"Explore a área: {local}.")
        {
            Local = local;
        }

        public override void Executar()
        {
            Console.WriteLine($"Você explorou a área: {Local}!");
            MarcarComoConcluida();
        }
    }
}