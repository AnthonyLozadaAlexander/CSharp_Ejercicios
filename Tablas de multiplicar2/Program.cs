bool On = true;
Console.Write("Ingresa un Numero: ");
string numero = Console.ReadLine();
int num = int.Parse(numero);

while (On)
{
  Console.WriteLine("");
  if (num >= 1)
  {
    Console.WriteLine($"La Tabla De Multiplicar Del {num} es: ");
    for (int i = 1; i <= 12; i++)
    {
      Console.WriteLine($"{num} x {i} = {num * i}");
    }
    On = false;
  }
  else
  {
    Console.WriteLine("El numero debe ser mayor a 0");
    Console.Write("Ingresa un Numero: ");
    numero = Console.ReadLine();
    num = int.Parse(numero);

  }
}

Console.Read();
