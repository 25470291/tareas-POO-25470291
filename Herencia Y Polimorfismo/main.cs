using System;
using System.Collections.Generic;



namespace Herencia_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>(); //la lista que guarda
            int opcion;
            do // el do que ejecuta al menos una vez
            {
                Console.WriteLine("********************* MENÚ DE FIGURAS  ********************");
                Console.WriteLine("1. Agrega una figura");
                Console.WriteLine("2. Resultados");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                    

                opcion = int.Parse(Console.ReadLine()); //para que se guarde lo que entre de la consola 
                Console.WriteLine("------------------------------------------------");


                switch (opcion)
                {
                    case 1:
                        AgregarFigura(figuras);
                        break;
                    case 2:
                        Resultados(figuras);
                        break;
                   
                }

            } while (opcion != 3); //no mas de 3 opciones 
        }
        static void AgregarFigura(List<Figura> figuras)
        {
            Console.WriteLine("1. Círculo\n2. Cuadrado\n3. Triángulo\n4. Rectangulo");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Proporciona el radio de este circulo:");
                    double radio = double.Parse(Console.ReadLine());
                    figuras.Add(new Circulo(radio)); //para que e guarde en la lista
                        break;

                case 2:
                    Console.WriteLine("Proporcione Lado del cuadrado:");
                    double lado = double.Parse(Console.ReadLine());
                    figuras.Add(new Cuadrado(lado));
                    break;

                case 3:
                    Console.WriteLine("Proporciones el dato para la Base:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Proporcione la el dato para la altura");
                    double h = double.Parse(Console.ReadLine());
                    figuras.Add(new Triangulo(b, h));
                    break;

                case 4:
                    Console.WriteLine("Ingrese el dato para para la Base:");
                    double br = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el dato para la Altura");
                    double hr = double.Parse(Console.ReadLine());
                    figuras.Add(new Rectangulo(br, hr));
                    break;

               
            }

        }
        static void Resultados(List<Figura> figuras)
        {
            foreach (Figura f in figuras)
            {
                Console.WriteLine($"{f.Nombre()}  Área: {f.CalcularArea():F2}"); //lo que se muestra en la consola 
            }
        }


    }
    }
    

