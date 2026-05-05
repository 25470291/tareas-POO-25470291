using System;

namespace Herencia_Polimorfismo
{
    public abstract class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }
        public virtual string Nombre()
        {
            return "Figura";
        }
    }
}
