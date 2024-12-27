//? Registra la calificacion de N alumnos e imprime en pantalla el alumno con el peor promedio y el alumno con el mejor promedio.

namespace Ejercicio_Calificaciones1
{
  class Program
    {
        static void Main(string[] args)
        {
          int alumnosCount = 0; // variable tipo entero para almacenar la cantidad de alumnos a registrar

          Console.WriteLine("Ingresa la cantidad de alumnos a registrar: ");
          alumnosCount = Convert.ToInt32(Console.ReadLine());
          decimal[,] arregloCalificaciones = new decimal[alumnosCount, 2]; // arreglo de 2, bidimensional

          Console.WriteLine("");

          for (int i = 0; i <= alumnosCount - 1; i++)
          {

            Console.WriteLine("Calificacion del alumno #" + (i + 1).ToString());
            arregloCalificaciones[i, 0] = Convert.ToDecimal(Console.ReadLine());//? Calificacion
            arregloCalificaciones[i, 1] = (i + 1); //? alumno
            Console.WriteLine("");

          }
          
          //? Obtener alumno con el mejor promedio
          decimal calificacion = 0;
          decimal alumno = 0;

          for (int i = 0; i <= alumnosCount - 1; i++)
          {

            if (arregloCalificaciones[i, 0] > calificacion)
            {
              calificacion = arregloCalificaciones[i, 0];
              alumno = arregloCalificaciones[i, 1];
            }

          }

          Console.WriteLine("El alumno con el mejor promedio es el alumno #{0} con una calificacion de: {1}", alumno.ToString(), calificacion.ToString());
          Console.WriteLine();

          //? Obtener alumno con el peor promedio
          calificacion = 10;
          alumno = 0;
          for (int i = 0; i <= alumnosCount - 1; i++)
          {
           if (arregloCalificaciones[i, 0] < calificacion)
           {
             calificacion = arregloCalificaciones[i, 0];
             alumno = arregloCalificaciones[i, 1] = (i + 1);
           }

          }
          Console.WriteLine("El alumno con el peor promedio es el alumno #{0} con una calificacion de: {1}", alumno.ToString(),
                                calificacion.ToString());

          Console.ReadKey();
        }
    
    }

}
