using System;

namespace Herencia_Polimorfismo
{
    internal class Rectangulo : Figura
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public Rectangulo(double br, double hr)
        {
            Base = br;
            Altura = hr;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
        public override string Nombre()
        {
            return "Rectangulo";
        }
    }
}
