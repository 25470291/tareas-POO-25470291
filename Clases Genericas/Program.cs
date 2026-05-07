using System;


namespace Clases_Genericas
{
    public class Caja<T>
    {
        //campo rpibado de tipo T 
        private T Contenido;

        //constructor que recibe tipo T 
        public Caja(T contenido)
        {
            Contenido = contenido;
        }
        public void Guardar(T NuevoContenido)
        {
            Contenido = NuevoContenido;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"El valor de contenido es {Contenido} :");
            Console.WriteLine($"El tipo de dato de contenido es: {typeof(T).Name}");
        }

        public T Obtener()
        {
            return Contenido;
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine($"Instanciando la clase caja con diferentes valores");
            Console.WriteLine("__________________________________________________________");

                Caja<int> nuevaCaja = new Caja<int>(100);
                nuevaCaja.MostrarDatos();
            nuevaCaja.Guardar(200);
            nuevaCaja.MostrarDatos();
           int valor = nuevaCaja.Obtener();
            Console.WriteLine($"El valor es: {valor}");
            Console.WriteLine("________________________________________________________");

            Caja<long> longCaja = new Caja<long>(2200);
            longCaja.MostrarDatos();
            longCaja.Guardar(330);
            longCaja.MostrarDatos();
            long seg_valor = longCaja.Obtener();
            Console.WriteLine($"El segundo valor es:{seg_valor} ");
            Console.WriteLine("____________________________________________________________");

            Caja<double> douCaja = new Caja<double>(235.7);
            douCaja.MostrarDatos();
            douCaja.Guardar(12.66);
            douCaja.MostrarDatos();
            double ter_valor = douCaja.Obtener();
            Console.WriteLine($"El tercer valor es: {ter_valor}");
            Console.WriteLine("____________________________________________________________");

            Caja<string> stCaja = new Caja<string>("Camila");
            stCaja.MostrarDatos();
            stCaja.Guardar("mejor amiga perruna");
            stCaja.MostrarDatos();
            string cuar_valor = stCaja.Obtener();
            Console.WriteLine($"El cuarto valor es {cuar_valor}");
            Console.WriteLine("_____________________________________________");

            Caja<decimal> deCaja = new Caja<decimal>(19.0m);
            deCaja.MostrarDatos();
            deCaja.Guardar(1234.87m);
            deCaja.MostrarDatos();
            decimal qui_valor = deCaja.Obtener();
            Console.WriteLine($"El quinto valor es: {qui_valor}");
            Console.WriteLine("_____________________________________________");




            Console.ReadLine();


            }
        }
    }

