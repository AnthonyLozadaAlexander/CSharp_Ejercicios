double C1, C2, H;
Console.WriteLine("-----------------------------");

Console.Write("Ingrese el valor del cateto 1: ");
C1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor del cateto 2: ");
C2 = Convert.ToDouble(Console.ReadLine());

// Se agrego una condicion if para que los catetos sean mayores a 0

if (C1 <= 0 || C2 <= 0)
{

 Console.WriteLine("Los catetos deben ser mayores a 0");

}
else{


  H = Math.Sqrt(Math.Pow(C1, 2) + Math.Pow(C2, 2));
  H = Math.Round(H, 2);

  Console.WriteLine("-----------------------------");

  Console.WriteLine($"La hipotenusa es: {H}");

  
}

Console.ReadKey();
