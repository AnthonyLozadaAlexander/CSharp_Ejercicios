using System;

namespace Ejercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
        double HorasTrabajadas;
        double SueldoPorHora;
        double SueldoTotal;
        string name;

        Console.Write("Ingrese su nombre: ");
        name = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas: ");
        HorasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su sueldo por hora: ");
        SueldoPorHora = Convert.ToDouble(Console.ReadLine());

        SueldoTotal = HorasTrabajadas * SueldoPorHora;
       
        Console.WriteLine("");
        Console.WriteLine("El Sueldo Del Trabajador " + name + " Es: " + SueldoTotal);

        Console.WriteLine("");
        Console.WriteLine("Presionar Un Boton Para Salir");
        Console.ReadKey();

    }

  }
}