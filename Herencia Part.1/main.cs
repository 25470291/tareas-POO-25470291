using System;

namespace Zootopia
{

    internal class Animales
    {


        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("-----------------ANIMALS--------------------");

                Leon leon = new Leon("León", "mamifero", "pelo", "carnivoro", 160);

                leon.MostrarInfoBase();
                Console.WriteLine($"Peso: {leon.Peso}");
                leon.Peso = 180;
                Console.WriteLine($"Nuevo Peso : {leon.Peso}");
                leon.Rugir();
                leon.Atacar();

                Console.WriteLine("________________________________________________________");
                Lobo lobo = new Lobo("Lobo", "mamifero", "pelo", "carnivoro", 67, true);
                lobo.MostrarInfoBase();
                lobo.ExplorarenManada();
                lobo.Aullar();
                if (lobo.EsLider)
                {
                    Console.WriteLine("El lobo es el líder de la manada ");
                }
                else
                {
                    Console.WriteLine("El lobo no es líder de la manada");
                }
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("--------------------ANIMAL MARINO------------------------");
                Tortuga tortuga = new Tortuga("Crush", "Animal Marino", " coriácea", "Herbívora",34, 135);
                tortuga.MostrarInfoBase();
                Console.WriteLine($"Longevidad: {tortuga.Longevidad}");
                tortuga.Longevidad = 150;
                Console.WriteLine($"Nueva Longevidad: {tortuga.Longevidad}");
                tortuga.PonerHuevos();
                tortuga.Nadar();

                Console.WriteLine("________________________________________________________");
                Console.WriteLine("--------------------ANIMAL ANFIBIO------------------------");

                Ajolote ajolote = new Ajolote("Salamandra", "Anfibio", "Suave", "Carnívoros", 2, 87);
                ajolote.MostrarInfoBase();
                Console.WriteLine($"Nivel de Regeneracion: {ajolote.NivelDeRegeneracion}");
                ajolote.NivelDeRegeneracion = 99;
                Console.WriteLine($"Nuevo Nivel de Regeneracion: {ajolote.NivelDeRegeneracion}");
                ajolote.Regenerar();
                ajolote.Nadar();

                Console.WriteLine("________________________________________________________");
                Console.WriteLine("--------------------ANIMAL REPTIL------------------------");

                Anaconda anaconda = new Anaconda("Coral", "Reptil", "Escamas", "Carnivora", 70, 6);
                anaconda.MostrarInfoBase();
                Console.WriteLine($"Tamaño: {anaconda.Tamaño}");
                anaconda.Tamaño = 8;
                Console.WriteLine($"Nuevo Tamaño:{anaconda.Tamaño}");
                anaconda.Cazar();
                anaconda.DevorarPresa();
                    
                    
                    
                   




                Console.ReadLine();

            }
        }
    }
}
