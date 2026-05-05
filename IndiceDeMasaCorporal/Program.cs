//Sahory Medina Chan POO 25470291 
//Programa que calcule el IMC de las personas y su estado actual 

using System;
namespace IndicedeMasaCorporal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double IMC, peso, estatura;
            string Mostrar_Info;
            Console.WriteLine("Agregue su peso (kg)");

            Console.WriteLine("__________________________________________");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Agregue su estatura (m)");
            estatura = double.Parse(Console.ReadLine());
            IMC = Math.Round(peso / (double)Math.Pow(estatura, 2), 2);



            if (IMC < 18.5)
            {
                Mostrar_Info = "Su estado es Bajo";
            }
            else if (IMC <= 25)
            {
                Mostrar_Info = "Su estado es Saludable";
            }
            else if (IMC <= 30)
            {
                Mostrar_Info = "Su estado es Sobrepeso";
            }

            else if (IMC <= 40)
            {
                Mostrar_Info = "Su estado es Obesidad";
            }
            else
            {
                Mostrar_Info = "Su estado es Obesidad Extrema";
            }
            Console.WriteLine("Su IMC es:" + IMC);
            Console.WriteLine(Mostrar_Info);
            Console.ReadKey();







        }
    }
}
