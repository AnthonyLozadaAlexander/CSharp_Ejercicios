using System;
namespace Funciones
{
  class Program
  {         
    //? Funcion que calcula el cuadrado de un numero
    static int Cuadrado(int valor)
    {
       return valor * valor; 
    }
   
   static void Main(string[] args) // argumento main, de inicio en cualquier programa.
   {
     // Programa para sacar el cuadrado de un numero
     Console.WriteLine("Programa para sacar el cuadrado de un numero");
     Console.WriteLine("---------------------------------------------");

     // Declaracion de variables
     int numero;
     Console.Write("Ingrese un numero: ");
     numero = Convert.ToInt32(Console.ReadLine()); // El usuario ingresara un valor por teclado

     //* int Resultado_Cuadrado;
     //* Calculo del cuadrado
     //* Resultado_Cuadrado = numero * numero;

     // Imprimimos el resultado
     Console.WriteLine($"El cuadrado de {numero} es: {Cuadrado(numero)}");
     Console.ReadKey();


   }
  }
}
