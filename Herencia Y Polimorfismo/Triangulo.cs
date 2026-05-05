using System;

namespace Herencia_Polimorfismo
{
    internal class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }
        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override string Nombre()
        {
            return "Triangulo";
        }

    }
}
