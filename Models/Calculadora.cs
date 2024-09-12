using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int dividir(int num1, int num2)
        {
            return  num1 / num2;
        }

        public int multiplicar(int num1, int num2)
        {
            return  num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int somar(int num1, int num2)
        {
            return  num1 + num2;
        }

        public int subtrair(int num1, int num2)
        {
            return  num1 - num2;
        }
    }
}