using System; //* using System; es una libreria que nos permite acceder a las clases de la libreria de .NET 

class Program_Logica
{
  public void ejercicio1()
  {

    Console.Write("Escribe tu nombre: ");
    var nombre = Console.ReadLine();
    Console.WriteLine("Hola " + nombre + " Bienvenido a C#");
    Console.ReadKey();
      
  }
  public void ejercicio2()
  {
    
    //? Area de un triangulo
    Double b, h, area;

    Console.WriteLine("Programa para calcular el area de un triangulo");
    Console.WriteLine("-------------------------------------------------");

    Console.Write("Ingrese la base del triangulo: ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese la altura del triangulo: ");
    h = Convert.ToDouble(Console.ReadLine());

    area = (b * h) / 2;
    
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine($"El area un triangulo con base {b} y altura {h} es: {area}");

    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Presione Cualquier Tecla Para Salir");
    Console.ReadKey();

  }
  public void ejercicio3()
  {

    







  }

  static void Main(string[] args)
  {

    Program_Logica obj = new Program_Logica();
    obj.ejercicio2();

  }
}

