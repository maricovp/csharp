using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_interface.Interface;

namespace exercicio_interface.Modelo
{
    public class Guerreiro : Heroi, IAtacante
    {


    public Guerreiro(string nome) : base(nome) {}

    public void Atacar()
    {
        Console.WriteLine(Nome + " golpeia com sua espada!");
    }

    public override void Especial()
    {
        Console.WriteLine(Nome + " usa a Fúria do Guerreiro!");
    }
    }
}