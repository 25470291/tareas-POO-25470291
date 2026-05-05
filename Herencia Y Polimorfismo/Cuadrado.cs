using System;


namespace Herencia_Polimorfismo
{
    internal class Cuadrado : Figura 
    {
        public double Lado { get; set; }

        public Cuadrado( double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
        public override string Nombre()
        {
            return "Cuadrado";
        }
    }
}
