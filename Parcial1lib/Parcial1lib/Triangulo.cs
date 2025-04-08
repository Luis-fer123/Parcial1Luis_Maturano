using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    public class Triangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double base_, double altura)
        {
            Base = base_;
            Altura = altura;
        }
        public override double Area()
        {
            return (Base * Altura) / 2;
        }
        public override double Perimetro()
        {
            return 3 * Base;
        }
    }
}