using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_interface.Interface;

namespace exercicio_interface.Modelo
{
    public class Mago : Heroi, IAtacante
    {

    public Mago(string nome) : base(nome) {}

    public void Atacar()
    {
        Console.WriteLine(Nome + " lança uma bola de fogo!");
    }

    public override void Especial()
    {
        Console.WriteLine(Nome + " invoca uma tempestade arcana!");
    }


    }
}