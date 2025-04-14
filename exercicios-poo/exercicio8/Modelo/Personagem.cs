using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8.Modelo
{
public class Personagem
    {
        public string Nome;
        public int ForcaBase;
        public int DefesaBase;

        public IArma ArmaEquipada;
        public IArmadura ArmaduraEquipada;

        public Personagem(string nome)
        {
            Nome = nome;
            ForcaBase = 10;
            DefesaBase = 5;
        }

        public int AtaqueTotal => ForcaBase + (ArmaEquipada?.AtaqueBonus ?? 0);
        public int DefesaTotal => DefesaBase + (ArmaduraEquipada?.DefesaBonus ?? 0);

        public void TrocarArma(IArma novaArma)
        {
            ArmaEquipada = novaArma;
            Console.WriteLine($"{Nome} equipou {novaArma.Nome} (+{novaArma.AtaqueBonus} ATK)");
        }

        public void TrocarArmadura(IArmadura novaArmadura)
        {
            ArmaduraEquipada = novaArmadura;
            Console.WriteLine($"{Nome} vestiu {novaArmadura.Nome} (+{novaArmadura.DefesaBonus} DEF)");
        }

        public void MostrarStatus()
        {
            Console.WriteLine($"\n--- Status de {Nome} ---");
            Console.WriteLine($"Ataque total: {AtaqueTotal}");
            Console.WriteLine($"Defesa total: {DefesaTotal}");
            Console.WriteLine($"Arma: {(ArmaEquipada?.Nome ?? "Nenhuma")}");
            Console.WriteLine($"Armadura: {(ArmaduraEquipada?.Nome ?? "Nenhuma")}");
            Console.WriteLine("----------------------------\n");
        }
    }
}