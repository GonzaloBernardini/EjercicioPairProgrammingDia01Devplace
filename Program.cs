using System;

namespace EjercicioPropuestoPairPDia01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un comercio tiene una promocion: si el precio total de compra es igual o superior a 10000,
            el precio tiene un descuento del 20 %.
            Realizar un metodo para tomar el precio de compra total como argumento y que nos calcule y devuelva
            el precio con descuento si se cumple la promocion.
            Dato adicional: el metodo debe devolver el mismo  precio si no se cumple el descuento */


           Console.WriteLine("Bienvenido! \nIntroduzca el precio total de la compra:");
            int totalPrice = Convert.ToInt32(Console.ReadLine());

            //llamamos al metodo descuento
            Console.WriteLine(Discount(totalPrice));
        }
        //Creamos el metodo descuento
        static int Discount(double t)
        {
            if (t >= 10000)
            {
                Console.Write("Este es el precio con descuento de su compra: ");
                //Realizamos el descuento del 20% sobre el precio y lo retornamos como entero
                t = t - (0.2 * t);
                return Convert.ToInt32(t);

            }
            else
            {
                //Como no tiene descuento devolvemos el precio original
                Console.WriteLine("Su compra no tiene descuento :");
                return Convert.ToInt32(t);
            }


        }
    }
}
