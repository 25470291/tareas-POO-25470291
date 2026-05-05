using System;

namespace Zootopia
{
    internal class Lobo : Animal 
    {
        public bool  EsLider { get; set; } 

        public Lobo (String nombre, string clasificacion, string piel, 
                      string alimentacion, int peso,  bool eslider)
                      : base(nombre, clasificacion, piel, alimentacion,peso)
        {
            EsLider = eslider;
        }

        public void Aullar()
        {
            Console.WriteLine("El Lobo esta Aullando");
        }

        public void ExplorarenManada()
        {
            Console.WriteLine("El Lobo esta explorando en manada");
        }


    }
}
