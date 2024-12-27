Console.Write("Ingresa un Numero: ");
string numero = Console.ReadLine();
int num = int.Parse(numero);

if(num >= 1 && num <= 12)
{

  for (int i = 1; i <= 12; i++)
  {
    Console.WriteLine($"{num} x {i} = {num * i}");
  }

}

Console.Read();
