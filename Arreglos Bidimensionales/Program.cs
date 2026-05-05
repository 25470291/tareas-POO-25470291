using System;

namespace Matriz_bidmensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double prom = 0;
            Console.WriteLine("Ingrese el número de fila:");//le pido al usuario que ingrese el tamaño de la matriz 
           
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________");
            Console.WriteLine("Ingrese el número de columna:");
            int columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columna];
            for (int i = 0; i < matriz.GetLength(0); i++) //for anidado para le pida los valores al usuario
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para [{i}.{j}]");
                    Console.WriteLine("____________________________________");
                   
                    
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < matriz.GetLength(0); i++) //otro for ahora para que recorra la matriz
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"La matriz es: [{i},{j}] = {matriz[i, j]}");
                    suma += matriz[i, j];
                    Console.WriteLine($"La suma de la matriz es {suma}");

                }
            }
           
            int elementos = fila * columna;
            prom = suma / elementos;
            Console.WriteLine($"El promedio de la matriz es:{prom}");


            Console.ReadLine();
    
                    
               
            
        }
    }
}
