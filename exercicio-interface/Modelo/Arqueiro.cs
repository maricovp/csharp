using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_interface.Interface;

namespace exercicio_interface.Modelo
{
    public class Arqueiro : Heroi, IAtacante
    {

    public Arqueiro(string nome) : base(nome) {}

    public void Atacar()
    {
        Console.WriteLine(Nome + " dispara uma flecha precisa!");
    }

    public override void Especial()
    {
        Console.WriteLine(Nome + " usa o Disparo Triplo!");
    }
    }   

}