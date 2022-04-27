using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Calculadora
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {

        }//fim do construtot

        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }//fim do somar

        public double Subitrair(double num1, double num2)
        {
            return num1 - num2;
        }

      public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if(num2 <= 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }

        public double Potencia(double bas, double expoente)
        {
            if (expoente == 1)
            {
                return bas;
            }
            else if (expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
        }

        public double Raiz(double num1)
        {
            if(num1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }
        }
    }//fim da classe
}//fim do projeto
