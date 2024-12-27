using System;

namespace LeerTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de Dos Numeros");
            Console.Write("Escribe tu Nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Escribe el primero numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;

            Console.WriteLine("Hola " + nombre + " el resultado de la suma de " + num1 + " + " + num2 + " es: " + resultado);

            Console.Read();

        }
    }
}