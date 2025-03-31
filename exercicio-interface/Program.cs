﻿using System;
using exercicio_interface.Modelo;

class Program
{
    static void Main()
    {
        Guerreiro guerreiro = new Guerreiro("Arthur");
        Mago mago = new Mago("Merlin");
        Arqueiro arqueiro = new Arqueiro("Robin");

        guerreiro.Atacar();
        guerreiro.Especial();

        mago.Atacar();
        mago.Especial();

        arqueiro.Atacar();
        arqueiro.Especial();
    }
}