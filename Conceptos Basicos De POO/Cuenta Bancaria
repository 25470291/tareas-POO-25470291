using System;

namespace cuenta_bancaria
{
    class CuentaBancaria
    {
        public string titular;
        public string NoDeCuenta;
        public double saldo;
        public int Nip;


        //metodos 
        
        public void depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"El saldo actual es: {saldo}");

        }
        public void retirar(double cantidad)
        {
            /*   if (saldo < cantidad)
               {
                   Console.WriteLine($"Saldos insufucientes");
               }
               else
               {
                   saldo -= cantidad;
                   Console.WriteLine($"El saldo acutual es: {saldo}");
               } */
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine($"Fondos insuficientes");
            }
        }
    public void ConsultarSaldo()
        {
            Console.WriteLine($"Bienvenido  {titular} al Banco ");
            Console.WriteLine($"número de cuenta: {NoDeCuenta}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Nip: {Nip}");
        }
        public void   CambiarNip(int nipactual,int  nuevonip)

        {
            if ( Nip == nipactual)
            {
                Nip = nuevonip;
                Console.WriteLine("se cambio el nip existosamente");
            }
            else
            {
                Console.WriteLine("ingreso su nip incorrecto");
            }
            
        }
        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           
         
            
            
            CuentaBancaria cuentaBancaria = new CuentaBancaria();
            cuentaBancaria.titular = "Jared Perdomo";
            cuentaBancaria.NoDeCuenta = "09112023";
            cuentaBancaria.saldo = 2500;
            cuentaBancaria.Nip = 150326;
            cuentaBancaria.ConsultarSaldo();
            

            Console.WriteLine("ingrese la cantidad para retirar");
           double cantidad = Convert.ToDouble(Console.ReadLine());

            cuentaBancaria.retirar(cantidad);
            Console.WriteLine("para cambiar su nip ingrese su nip actual");
            int nipactual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese su nuevo nip");
            int nuevonip = Convert.ToInt32(Console.ReadLine());


            cuentaBancaria.CambiarNip(nipactual, nuevonip);

            Console.ReadLine();

        }
    }
}

