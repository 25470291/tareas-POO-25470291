//Boletos de Ávion Sahory Medina Chan POO 25470291 
using System;
using System.Globalization;
namespace BoletosDeAvion
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int tipo, bole;
            double totalbole;
            double precio = 0;
            double descuento = 0;
            double totaldes = 0;
            double TUA = 0;
            double totalfinal;
            double importeIVA;
            double IVA;
            double importetotal;
            string Boletos;
            Console.WriteLine("Cuantos boletos desea adquirir?");
            Console.WriteLine("_______________________________________________________________");
            bole = int.Parse(Console.ReadLine());
            Console.WriteLine("Su viaje es Sencillo (ponga 1) o Redondo (ponga 2). ");
            Console.WriteLine("_______________________________________________________________");

            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                precio = 1100;
                Console.WriteLine("Su importe unitario es de  $1,100");
            }
            else if (tipo == 2)
            {
                precio = 2000;
                Console.WriteLine("Su importe unitario es de $2,000");
            }


            totalbole = bole * precio;
            Console.WriteLine("Su importe de los boletos es de:$" + totalbole);
            totalfinal = totalbole; //antes de que haga el descuento se aplica dscuento, si no aplica seguira siendo total bole 

            if (tipo == 2 && bole >= 3)
            {
                descuento = totalbole * 0.2;
                Console.WriteLine("Su descuento fue de:$" + descuento);
                totalfinal = totalbole - descuento;
                Console.WriteLine("Su importe aplicando el descuento es de:$" + totalfinal);
            }
            TUA = totalfinal * 0.12;
            Console.WriteLine("Su importe TUA es de:$" + TUA);
            importeIVA = totalfinal + TUA;
            Console.WriteLine("Su importe sobre el cual se aplica el IVA es de:$" + importeIVA);
            IVA = importeIVA * 0.16;
            Console.WriteLine("Su importe IVA es:$" + IVA);
            importetotal = totalfinal + TUA + IVA;
            Console.WriteLine("Su importe total con descuentos es de:$" + importetotal);




            Console.ReadKey();
            

    
}
    }
}
