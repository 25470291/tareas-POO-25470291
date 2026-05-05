using System;

namespace Herencia_Polimorfismo
{
     class Circulo : Figura //HERENDANDO
    {
        public double Radio {  get; set;}

        public Circulo (double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2); //usando lo del system para hacer mas simple la expresion
        }
        public override string Nombre()
        {
            return "Circulo";
        }
    }

}
