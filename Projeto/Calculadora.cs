using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Calc
{
    public class Calculadora
    {
        private List<string> lista = new List<string>();
        public int Somar(int num1, int num2)
        {
            lista.Insert(0, $"{num1} + {num2} = {num1+num2}");
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            lista.Insert(0, $"{num1} - {num2} = {num1-num2}");
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            lista.Insert(0, $"{num1} * {num2} = {num1*num2}");
            return num1 * num2;
        }
        public double Dividir(int num1, int num2)
        {
            lista.Insert(0, $"{num1} / {num2} = {num1/num2}");
            return num1 / num2;
        }
        public List<string> Historico()
        {       
            lista.RemoveRange(3, lista.Count()-3);
            return lista;
        }
    }
}