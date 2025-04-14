using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4.Modelo
{
public class Inventario
    {
        private List<Item> itens;
        private int capacidadeMaxima;

        public Inventario(int capacidade)
        {
            capacidadeMaxima = capacidade;
            itens = new List<Item>();
        }

        public void Adicionar(Item item)
        {
            if (itens.Count >= capacidadeMaxima)
            {
                Console.WriteLine("Inventário cheio! Não é possível adicionar mais itens.");
                return;
            }

            itens.Add(item);
            Console.WriteLine($"{item.Nome} adicionado ao inventário.");
        }

        public void Remover(Item item)
        {
            if (itens.Remove(item))
            {
                Console.WriteLine($"{item.Nome} removido do inventário.");
            }
            else
            {
                Console.WriteLine($"{item.Nome} não está no inventário.");
            }
        }

        public void UsarItem(string nomeItem)
        {
            Item item = itens.FirstOrDefault(i => i.Nome == nomeItem);
            if (item != null)
            {
                item.Usar();
                Remover(item);
            }
            else
            {
                Console.WriteLine($"Item {nomeItem} não encontrado.");
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n--- Inventário ---");
            foreach (var item in itens)
            {
                Console.WriteLine($"- {item.Nome}");
            }
            Console.WriteLine("-------------------\n");
        }
    }
}