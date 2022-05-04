using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double costoTotal, costoComprador, ganancia, impuestos = 0; 

            Console.WriteLine("Ingrese el valor total del vehículo: ");

            costoTotal = double.Parse(Console.ReadLine());

            ganancia = costoTotal * 0.12;

            impuestos = costoTotal * 0.06;

            costoComprador = costoTotal + ganancia + impuestos;

            Console.WriteLine("El costo  del consumidor es: " + costoComprador);

            Console.ReadKey();


        }
    }
}
