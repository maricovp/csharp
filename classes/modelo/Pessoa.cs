using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.modelo
{
    public class Pessoa
    
        string nome;
        int idade;
        double altura;
        double peso;

        public Pessoa(string nome, int idade,double altura,double peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }
        public void Andar()
        {
            Console.WriteLine($"{nome} está andando");
        }
        public void Falar()
        {
            Console.WriteLine($"{nome} vou ficar rico programando em C#!")
        }
    
}