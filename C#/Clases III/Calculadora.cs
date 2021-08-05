using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_III
{
    class Calculadora
    {
        public double[] numeros;
        public double resultado;

        public Calculadora(double[] operandos)
        {
            this.numeros = operandos;
        }

        public double suma()
        {
            foreach (double item in numeros)
            {
                resultado += item;
            }
            return resultado;
        }
        public double resta()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0)
                {
                    resultado = numeros[i];
                }
                else
                {
                    resultado -= numeros[i];
                }

            }
            return resultado;
        }
    }
}
