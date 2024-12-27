using System;

class Program
{
    static void Main()
    {
        int a, b;

        Console.Write("Ingrese el primer numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        int resultado = Sumar(a, b);
        Console.WriteLine($"La suma de {a} y {b} es: {resultado}");
        Console.Read();
    }
    // funcion
    static int Sumar(int x, int y)
    {
       return x + y;
    }
}
