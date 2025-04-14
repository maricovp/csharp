using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8.Modelo
{
public class Arco : IArma
    {
        public string Nome => "Arco Elétrico";
        public int AtaqueBonus => 7;
    }
}