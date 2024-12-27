int num;
Console.WriteLine("Determinar si un numero tiene 3 digitos");
Console.WriteLine("----------------------------------------");
Console.Write("Ingrese un numero: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------");

if (num >= 100 && num <= 999)
{

  Console.WriteLine("El numero tiene 3 digitos");

}
else
{

Console.WriteLine("El numero no tiene 3 digitos");

}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Press a Button to Exit");
Console.ReadKey();
