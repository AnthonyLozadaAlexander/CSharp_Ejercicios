using System;

namespace Tablas_De_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
          
          int num;
          int resultado;
          // int contador; es mas practico usar int i; como contador o iterador
          Console.Write("Ingrese un numero el cual sera multiplicado hasta el 12: ");
          num = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("-------------------------------------------------------");

          for(int i = 1; i <= 12; i++) //? Para i desde 1 hasta 12 hacer
          {

             resultado = num * i;
             Console.WriteLine("El resultado de la multiplicacion es: " + num + " x " + i + " = " + resultado);

          }

          Console.WriteLine("---------------------------------------------------------");
          Console.WriteLine("Presione cualquier tecla para salir");
          Console.Read();

        }
    
    }
} 
