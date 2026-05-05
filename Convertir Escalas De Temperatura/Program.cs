using System;



namespace Convertir_Temperaturas
{
    internal class Program
    {
        static double ConvertC_F(double Cel)

        {
            return (Cel * 1.8) + 32;

        }

        static double ConvertF_C(double Far)
        {
            return (Far - 32) / 1.8;
        }

        static double ConvertC_K(double Cel)
        {
            return Cel + 273.15;
        }
        static double ConvertK_C(double Kel)
        {
            return Kel - 273.15;
        }
        static void MostrarTitulo()
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************CONVERSIÓN DE ESCALAS DE TEMPERATURAS*******************");
            Console.ResetColor();

        }
        static void Main(string[] args)
        {
            string Seguir;
            do
            {
                int opcion;
                double resultado;

                double dato;
                MostrarTitulo();

                Console.WriteLine("Ingrese que escalas quiere convertir:");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1 - CONVERTIR DE CELSIUS A FAHRENHEIT");
                Console.WriteLine("2 - CONVERTIR DE FAHRENHEIT A CELCIUS");
                Console.WriteLine("3 - CONVERTIR DE CELSIUS A KELVIN");
                Console.WriteLine("4 - CONVERTIR DE KELVIN A CELSIUS");
                Console.WriteLine("_______________________________________");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la escala que le gustaría convertir:");
                dato = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            resultado = ConvertC_F(dato);
                            Console.WriteLine($"La conversion a {dato} C° da: {resultado} F°");

                            break;
                        }

                    case 2:
                        {
                            resultado = ConvertF_C(dato);
                            Console.WriteLine($"La conversión a {dato} F° da: {resultado} C°");

                            break;
                        }
                    case 3:
                        {
                            resultado = ConvertC_K(dato);
                            Console.WriteLine($"La conversión a {dato} C° da: {resultado} K°");
                            break;
                        }
                    case 4:
                        {
                            resultado = ConvertK_C(dato);
                            Console.WriteLine($"La conversión a {dato} K° da: {resultado} C°");
                            break;
                        }

                      }
                Console.WriteLine("_______________________________________");
                Console.WriteLine("Desea continuar con el programa?");
                Seguir = Console.ReadLine().ToUpper();

            }
            while (Seguir == "S");

        }
    }
}

