using System;

namespace Zootopia
{
    internal class Ajolote : Animal 
    {
        public int NivelDeRegeneracion { get; set; }

        public Ajolote(String nombre, string clasificacion, string piel,
                    string alimentacion,int peso, int nivelderegeneracion)
                    : base(nombre, clasificacion, piel, alimentacion, peso)
        {
            NivelDeRegeneracion = nivelderegeneracion;
        }
        public void Regenerar()
        {
            Console.WriteLine("El Ajolote se esta Regenerando");
        }

        public void Nadar()
        {
            Console.WriteLine("El Ajolote esta nadando");
        }
    }
}
