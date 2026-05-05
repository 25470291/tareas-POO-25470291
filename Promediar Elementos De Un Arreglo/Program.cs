using System;

namespace Promediar_arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Prom, suma, no1, no2, no3,no4, no5; // declaración de variales (decimales)

            
            Console.WriteLine("Ingrese un número");
            Console.WriteLine("__________________________________________"); //decoración 
            no1 = double.Parse(Console.ReadLine()); //la entrada esta con texto y esto lo lee a números 
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Ingrese un segundo número");
            no2 = double.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Ingrese un tercer número");
            no3 = double.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Ingrese un cuarto número");
            no4 = double.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Ingrese un quinto número");
            no5 = double.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");


            double[] numeros = { no1, no2, no3, no4, no5 }; 
            Console.WriteLine("su arreglo queda así:");
            for (int i = 0; i < numeros.Length; i++) //arreglo
            {
                Console.WriteLine(numeros[i] +"");
            }
            suma = no1 + no2 + no3 + no4 + no5; //se realiza la suma
          
            Prom = suma / 5;
            Console.WriteLine("Su promedio es:" + Prom); //se muestra su promedio 


            Console.ReadKey();//finalizando el programa

           
        }
    }
}
