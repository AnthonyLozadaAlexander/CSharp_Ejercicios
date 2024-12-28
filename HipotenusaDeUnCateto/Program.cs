double C1, C2, H;
Console.WriteLine("-----------------------------");

Console.Write("Ingrese el valor del cateto 1: ");
C1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor del cateto 2: ");
C2 = Convert.ToDouble(Console.ReadLine());

if (C1 <= 0 || C2 <= 0)
{
  
 Console.WriteLine("Los catetos deben ser mayores a 0");

}
else{


  H = Math.Sqrt(Math.Pow(C1, 2) + Math.Pow(C2, 2));

  Console.WriteLine("-----------------------------");

  Console.WriteLine($"La hipotenusa es: {H}");
  
}


Console.ReadKey();
