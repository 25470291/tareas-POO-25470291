using System;

namespace Clase_Phone
{
    class Telefono
    {
        public int Bateria;
        public string Marca;
        public string Modelo;
        public string SistemaOperativo;
        public int CapacidadRAM;

        public void Llamar()
        {
            Console.WriteLine($"El {Marca} {Modelo} esta llamando ");
        }

        public void EnviarMensaje()
        {
            Console.WriteLine($"El {Modelo} esta haciendo una llamada");
        }

        public void TomarFoto()
        {
            Console.WriteLine($"El telefono tomo una foto con la camara");
        }

        public void VerCarga()
        {
            Bateria = 80;
            Console.WriteLine($"El telefono tiene {Bateria} de bateria ");
        }

        public void VerDatos()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Bateria: {Bateria}");
            Console.WriteLine($"CapacidadRAM: {CapacidadRAM}");
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Telefono telefono1 = new Telefono();
                telefono1.Marca = "Samsung";
                telefono1.Modelo = "A36";
                telefono1.SistemaOperativo = "Android 15";
                telefono1.CapacidadRAM = 8;
                telefono1.Bateria = 80;

                telefono1.VerDatos();
                telefono1.TomarFoto();
                telefono1.VerCarga();
                telefono1.Llamar();
                telefono1.EnviarMensaje();
                Console.WriteLine("__________________________________");

                Telefono telefono2 = new Telefono();
                telefono2.Marca = "Iphone";
                telefono2.Modelo = "15 Pro Max";
                telefono2.SistemaOperativo = "iOS";
                telefono2.CapacidadRAM = 8;
                telefono2.Bateria = 80;

                telefono2.VerDatos();
                telefono2.TomarFoto();
                telefono2.VerCarga();
                telefono2.Llamar();
                telefono2.EnviarMensaje();



                Console.ReadLine();

            }
        }
    }
}
