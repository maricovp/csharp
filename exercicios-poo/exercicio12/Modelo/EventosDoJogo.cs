using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio12.Modelo
{
public static class EventosDoJogo
    {
        // Delegate base
        public delegate void EventoSimples();

        // Eventos do jogo
        public static event EventoSimples ChefeDerrotado;
        public static event EventoSimples JogadorSubiuNivel;
        public static event EventoSimples MissaoConcluida;

        // Métodos para disparar os eventos
        public static void DispararChefeDerrotado()
        {
            Console.WriteLine("\n[Evento] Chefe foi derrotado!");
            ChefeDerrotado?.Invoke();
        }

        public static void DispararJogadorSubiuNivel()
        {
            Console.WriteLine("\n[Evento] Jogador subiu de nível!");
            JogadorSubiuNivel?.Invoke();
        }

        public static void DispararMissaoConcluida()
        {
            Console.WriteLine("\n[Evento] Missão foi concluída!");
            MissaoConcluida?.Invoke();
        }
    }
}