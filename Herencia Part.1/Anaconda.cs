using System;

namespace Zootopia
{
    internal class Anaconda : Animal
    {
        public int Tamaño { get; set; } //metros

        public Anaconda(String nombre, string clasificacion, string piel,
                   string alimentacion,int peso, int tamaño)
                   : base(nombre, clasificacion, piel, alimentacion,peso)
        {
            Tamaño = tamaño;
        }
        public void Cazar()
        {
            Console.WriteLine("La Anaconda esta cazando su proxima presa");
        }
         public void DevorarPresa()
        {
            Console.WriteLine("La Anaconda esta devorando a su presa");
        }
    }
}
