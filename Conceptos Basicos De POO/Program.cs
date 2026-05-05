using System;

namespace Clase_student
{
    class Estudiante
    {

        public string Nombre;
        public int Edad;
        public string Apellido;
        public int Matricula;
        public int Semestre;
        public string Carrera;
        public int Nip;

        public void Estudiar()
        {
            Console.WriteLine($"Nombre: {Nombre} esta estudiando");
        }
        public void MostraHistorial()
        {
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad {Edad}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Semestre: {Semestre}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nip: {Nip}");

        }
        public void  EntrarPortal( int nipactual,int  nuevonip)
        {
            if (Nip == nipactual)
            {
                Nip = nuevonip;
                Console.WriteLine("Se cambio el nip existosamente");
            }
            else
            {
                Console.WriteLine("Ha ingresado el Nip incorrecto");
            }
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Sahory ";
            estudiante1.Apellido = "Medina";
            estudiante1.Edad = 18;
            estudiante1.Carrera = "ing. en Tic´s";
            estudiante1.Semestre = 2;
            estudiante1.Nip = 091123;
            estudiante1.Matricula = 25470291;

            estudiante1.Estudiar();
            estudiante1.MostraHistorial();
            Console.WriteLine("Para entrar ingrese su nip actutal");
            int nipactual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nuevo nip:");
            int nuevonip = Convert.ToInt32(Console.ReadLine());
            estudiante1.EntrarPortal(nipactual, nuevonip);

            Estudiante estudiante2 = new Estudiante();
            estudiante2.Nombre = "Tom";
            estudiante2.Apellido = "Hiddleston";
            estudiante2.Edad = 19;
            estudiante2.Carrera = "Ing. Ambiental";
            estudiante2.Semestre = 8;
            estudiante2.Matricula = 219802;
            estudiante2.Nip = 020721;
            
            estudiante2.Estudiar();
            estudiante2.MostraHistorial();



            Console.ReadKey();
        }
    }
}
