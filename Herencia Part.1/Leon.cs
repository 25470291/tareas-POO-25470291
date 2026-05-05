using System;

namespace Zootopia
{
    public class Leon : Animal
    {
        
        public Leon(string nombre, string clasificacion, string piel, string alimentacion, int peso) :
            base(nombre, clasificacion, piel, alimentacion,peso)
        {
            Peso = peso;
        }

      

        public void Rugir ()
        {
            Console.WriteLine("El León ruge");
        }
        public void Atacar ()
        {
            Console.WriteLine("El León ataca");
        }



    }
}
