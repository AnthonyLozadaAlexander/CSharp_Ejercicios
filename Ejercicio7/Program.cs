using System;

namespace Ejercicio7
{
  class Program
  {
    public static void Main(string[] args)
    {
        double iva, total, grantotal, costo = 0;
        int cantidad = 0;
        string valor = "";
        iva = 0;
        total = 0;
        grantotal = 0;

        Console.WriteLine("Ingrese el Costo");
        valor = Console.ReadLine();
        costo = Convert.ToDouble(valor);

        Console.WriteLine("Ingrese la Cantidad");
        valor = Console.ReadLine();
        cantidad = Convert.ToInt32(valor);

        // calculamos el total
        total = cantidad * costo;

        // calculamos el iva
        iva = total * 0.16;

        // calculamos el gran total
        grantotal = total + iva;
        
    }
  }
}