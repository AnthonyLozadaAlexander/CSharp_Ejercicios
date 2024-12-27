using System;

namespace Suma_NumerosArrays
{
  class Program
  {
     static void Main(string[] args)
     {

      

      Console.WriteLine("Escribir un algoritmo que solicite al usuario varios numeros y los almanece en un arreglo, Suma todos los números del arreglo y muestre el resultado.");
      Console.WriteLine("------------------------------------------------------------------");
      
      Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar: ");
      int CantidadNum;
      if (int.TryParse(Console.ReadLine(), out CantidadNum) && CantidadNum > 0)
      { // si el valor ingresado es un numero entero y mayor a 0

          int[] numeros = new int[CantidadNum]; //? Declaracion de arreglo que almacena una cantidad de numeros enteros ingresadas por teclado.
          int Suma = 0;

            for (int i = 0; i <= CantidadNum-1; i++)
            { //? Para i desde 0 hasta CantidadNum - 1 hacer

                Console.Write($"Ingrese el numero {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {

                 Suma = Suma + numeros[i]; //? Incremento de la suma de los numeros ingresados por el usuario, y se almacena en la variable Suma, por cada iteracion suma va aumentando de valor, hasta llegar a la ultima iteracion de i <= cantidadNum - 1, (Hasta que i sea igual a CantidadNum - 1)

                }
                else
                {

                  Console.WriteLine("Porfavor ingrese un numero valido");
                  i--;
              
                }   
            }        
        Console.WriteLine($"La suma de los numeros ingresados es: {Suma}");
      }
      else //? Si el valor ingresado no es un numero entero o es menor a 0
      {

       Console.WriteLine("Porfavor ingrese un numero valido");

      }

      Console.ReadKey();

     }
  }
}
