using System.Runtime.InteropServices;

interface IAtaque {
    void Atacar ();
}
class guerreiro : IAtaque {
    public void Atacar () {
        Console.WriteLine ("Guerreiro ataca com a espada");
    }
}
class Mago : IAtaque {
    public void Atacar(){
        Console.WriteLine ("Mago lança bola de fogo");
    }
}
    class Arqueiro : IAtaque {
        public void Atacar() {
            Console.WriteLine ("Arqueiro dispara flechas");
        }
    }
    class program {
        static void Main (string[] args)  {
            IAtaque guerreiro = new guerreiro();
            IAtaque mago= new Mago();
            IAtaque arqueiro = new Arqueiro();
            
            guerreiro.Atacar();
            mago.Atacar ();
            arqueiro.Atacar ();

        }

    }
