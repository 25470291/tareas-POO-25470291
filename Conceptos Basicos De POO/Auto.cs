using System;

namespace Clase_Auto
{
    class Auto
    {
        public string color { get; set; }
        public string modelo { get; set; }

        public string marca { get; set; }

        public int kilometraje { get; set; }

        public void encender()
        {
            Console.WriteLine($"su coche {marca} esta encendido");
        }


        public void frenar()
        {
            Console.WriteLine($"su coche  esta frenando ");
        }

        public void acelerar()
        {
            Console.WriteLine($"su coche {color} esta acelerando");
        }

        public void mostrarKilometraje()
        {
            Console.WriteLine($"su coche {modelo} tiene {kilometraje} de kilometraje");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Auto auto1 = new Auto();

                auto1.color = "Rojo";
                auto1.modelo = "Deportivo";
                auto1.marca = "BMW";
                auto1.kilometraje = 1287;
                auto1.encender();
                auto1.frenar();
                auto1.acelerar();
                auto1.mostrarKilometraje();


                Console.ReadLine();
            }
           
        }
    }
}
