﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaExemploComOO
{
    internal class Triangulo
    {
        double lado1;
        double lado2;
        double lado3;

        public Triangulo()
        {

        }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        public double Lado3 { get => lado3; set => lado3 = value; }        
    }    
}
