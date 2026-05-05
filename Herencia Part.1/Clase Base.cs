using System;

namespace Zootopia
{
    public class Animal
    {
           public string Nombre { get; set; }
           public string Clasificacion { get; set; }
           public string Piel { get; set; }
           public string Alimentacion { get; set; }

           public int Peso { get; set; }
        //METODOS

        public Animal()
        {

        }
        public Animal(string nombre, string clasificacion, string piel, string alimentacion, int peso)
        {
            Nombre = nombre;
            Clasificacion = clasificacion;
            Piel = piel;
            Alimentacion = alimentacion;
            Peso = peso;
        
        }

        public void MostrarInfoBase()
        {
            Console.WriteLine($"Datos del animal:{Nombre} {Clasificacion}, {Piel}, {Alimentacion} {Peso}");

            Console.ReadLine();
        }
    }
    
}
