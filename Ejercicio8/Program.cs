using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float libras, onzas, kg_1, kg_2;
            Console.Write("Ingrese Las Libras: ");
            libras = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Las Onzas: ");
            onzas = float.Parse(Console.ReadLine());

            kg_1 = libras * 0.45359237f;
            kg_2 = onzas * 0.028349523125f;

            Console.WriteLine($"Las Libras en kg son: {kg_1}");
            Console.WriteLine($"Las Onzas en kg son: {kg_2}");

            Console.ReadKey();
            
        }
    }
}
