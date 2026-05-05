using System;

namespace Zootopia
{
    internal class Tortuga : Animal 
    {
        public int Longevidad { get; set; }

        public Tortuga(String nombre, string clasificacion, string piel,
                     string alimentacion,int peso, int longevidad)
                     : base(nombre, clasificacion, piel, alimentacion, peso)
        {
            Longevidad = longevidad;
        }
        public void PonerHuevos()
        {
            Console.WriteLine("La Tortuga esta poniendo huevos");

        }

        public void Nadar()
        {
            Console.WriteLine("La Tortuga esta Nadando");
        }
    }
}
