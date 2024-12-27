using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  public class Alumno
  {
    public string Nombre { get; set; }
    public List<double> Calificaciones { get; set; }
   
    public double Promedio => Calificaciones.Average();
  }

  static void Main(string[] args)
    {
        List<Alumno> alumnos = new List<Alumno>();

        Console.Write("Ingrese el numero de alumnos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

          Console.Write("Ingrese el nombre del alumno: ");
          string nombre = Console.ReadLine();

          Console.Write("Ingrese el numero de calificaciones: ");
          int m = int.Parse(Console.ReadLine());

          List<double> calificaciones = new List<double>();

          for (int j = 0; j < m; j++)
          {

            Console.Write($"Ingrese la calificacion {j + 1}: ");
            double calificacion = double.Parse(Console.ReadLine());
            calificaciones.Add(calificacion);

          }
 
          alumnos.Add(new Alumno { Nombre = nombre, Calificaciones = calificaciones });

        }

        Alumno mejorPromedio = alumnos.OrderByDescending(a => a.Promedio).First();
        Alumno peorPromedio = alumnos.OrderBy(a => a.Promedio).First();

        Console.WriteLine($"El alumno con el mejor promedio es: {mejorPromedio.Nombre} con un promedio de {mejorPromedio.Promedio}");
        Console.WriteLine($"El alumno con el peor promedio es: {peorPromedio.Nombre} con un promedio de {peorPromedio.Promedio}");

    }
    
}
