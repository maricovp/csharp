using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
public class ItemRandomizer
    {
        private static Random random = new Random();

        public static Item GerarItemAleatorio()
        {
            int sorteio = random.Next(3); // 0 a 2
            ItemFactory factory;

            switch (sorteio)
            {
                case 0:
                    factory = new ArmaFactory();
                    break;
                case 1:
                    factory = new PocaoFactory();
                    break;
                case 2:
                default:
                    factory = new ArmaduraFactory();
                    break;
            }

            return factory.CriarItem();
        }
    }
}