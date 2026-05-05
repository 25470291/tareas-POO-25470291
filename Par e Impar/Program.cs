// Sahory Medina Chan POO 25470291
// Programa que indique si un número entero es PAR o IMPAR

using System;
namespace Par_o_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Seguir = true;
            while (Seguir)
            {

                int numero;
                Console.WriteLine("ingrese un número entero");
                Console.WriteLine("_________________________________________________________________");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0)
                {
                    Console.WriteLine("El número es 0 y es PAR");
                }
                else if  (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es PAR");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es IMPAR");

                }
                Console.WriteLine("Desea ingresar otro número? Si/No");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "no") 
                Seguir = false;
            }
            

                Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
