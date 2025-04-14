using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio10.Modelo
{
public class Mercado : ISujeito
    {
        private Dictionary<string, double> precos = new Dictionary<string, double>();
        private List<IObservador> observadores = new List<IObservador>();

        public void AdicionarObservador(IObservador obs)
        {
            observadores.Add(obs);
        }

        public void RemoverObservador(IObservador obs)
        {
            observadores.Remove(obs);
        }

        public void NotificarObservadores(string item, double novoPreco)
        {
            foreach (var obs in observadores)
            {
                obs.Atualizar(item, novoPreco);
            }
        }

        public void AtualizarPreco(string item, double novoPreco)
        {
            precos[item] = novoPreco;
            Console.WriteLine($"\n[Mercado] Novo preço de {item}: {novoPreco} gold");
            NotificarObservadores(item, novoPreco);
        }
    }
}