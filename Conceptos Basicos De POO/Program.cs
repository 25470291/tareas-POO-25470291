using System;

namespace Clase_Pet
{
    class Mascota
    {
        public string Color {  get; set;}
        public string Nombre { get; set;}
        public string Raza { get; set; }
        public int Edad {  get; set;}
        public string Sexo { get; set;}


        public void Jugar()
        {
            Console.WriteLine($"{Nombre} esta jugando en el patio");
        }

        public void Comer()
        {
            Console.WriteLine($"{Nombre} esta comiendo");
        }

        public void Correr ()
        {
            Console.WriteLine($"{Nombre} esta corriendo"); 
        }

        public void HacerSonido()
        {
            Console.WriteLine($"{Nombre} hace: guaau");
        }
        public void Info()
        {
            Console.WriteLine($"nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Raza: {Raza}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            mascota1.Nombre = "Camila";
            mascota1.Raza = "Mestiza";
            mascota1.Sexo = "Hembra";
            mascota1.Edad = 11;

            mascota1.Info();
            mascota1 .HacerSonido();
            mascota1.Jugar();
            mascota1.Comer();
            mascota1.Correr();

            Console.ReadLine();
        }
    }
}
