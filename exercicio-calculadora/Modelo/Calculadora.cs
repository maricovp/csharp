using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_calculadora.Modelo
{

    public class Calculadora
    {
        // Método de soma
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Método de subtração
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        // Método de multiplicação
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método de divisão
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return a / b;
        }
    }
}

