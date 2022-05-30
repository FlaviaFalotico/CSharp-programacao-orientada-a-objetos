using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioOO_2
{
    internal class Salario
    {
        private String nomeFunc;
        private double salarioFunc;

        public string NomeFunc { get => nomeFunc; set => nomeFunc = value; }
        public double SalarioFunc { get => salarioFunc; set => salarioFunc = value; }

        public Salario()
        {

        }

        public Salario(string nomFunc, double salarioFunc)
        {
            this.nomeFunc = nomFunc;
            this.salarioFunc = salarioFunc;

        }
    }
}
