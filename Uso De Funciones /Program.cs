using System;



namespace uso_de_funciones
{
    internal class Program
    {
        static void MostrarTitulo()
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************USO DE FUNCIONES*******************");
            Console.ResetColor();

        }
        static double Sumar(double no1, double no2)
        {
            return no1 + no2;
        }
        static double Restar(double no1, double no2)
        {
            return no1 - no2;
        }
        static double Multiplicacion(double no1, double no2)
        {
            return no1 * no2;
        }
        static double Division(double no1, double no2)
        {
            return no1 / no2;

        }

        static void Main(string[] args)
        {
            string continuar;
            do
            {
                int opcion;
                double respuesta;
                double no1;
                double no2;
                double resultado;


                MostrarTitulo();//hizo el llamado

                Console.WriteLine("Qué operación desea realizar?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1-SUMA");
                Console.WriteLine("2-RESTA");
                Console.WriteLine("3-MULTIPLICACIÓN");
                Console.WriteLine("4-DIVISIÓN");
                Console.ResetColor();
                Console.WriteLine("____________________________________");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("________________________________________");
                Console.WriteLine("Ingrese el primer número");
                no1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                Console.WriteLine("____________________________________");
                no2 = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = Sumar(no1, no2);
                        Console.WriteLine($"El resultado de la suma es: {resultado}");
                        break;
                    case 2:
                        {
                            resultado = Restar(no1, no2);
                            Console.WriteLine($"El resultado de la resta es: {resultado}");
                            break;
                        }
                    case 3:
                        {
                            resultado = Multiplicacion(no1, no2);
                            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                            break;

                        }
                    case 4:
                        {
                            if (no2 == 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" ERROR");
                                Console.ResetColor();
                            }
                            else
                            {
                                resultado = Division(no1, no2);
                                Console.WriteLine($"El resultado de la división es: {resultado}");

                            }
                            break;
                        }



                }
                Console.WriteLine("Desea continuar con el programa?");
                continuar = Console.ReadLine().ToUpper();
            }
            while (continuar == "S");
        }

    }
}
