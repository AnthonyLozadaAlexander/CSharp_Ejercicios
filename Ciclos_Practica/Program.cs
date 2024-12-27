Console.WriteLine("Uso de Break");

for (int i = 0; i < 10; i++)
{

  if (i == 5)
  {

    break; // terminacion del ciclo

  }

  Console.WriteLine("Valor del contador i: {0}", i);

}

Console.WriteLine("Uso de Continue");

int n = 0; // int n inicializado en 0
while (n < 10) // mientras n sea menor a 10
{

  if (n % 2 == 0) //? condicion para determinar si es par
  {

    n++; //? no olvidar n++( n = n + 1) o si no sera un ciclo infinito
    continue; //? se salta el resto del ciclo

  }

  Console.WriteLine("Valor del contador n: {0}", n);
  n++; //? no olvidar n++( n = n + 1) o si no sera un ciclo infinito

}

Console.Read();

