//? Escribe un programa que muestre los primeros 10 numeros primos.

int contadorPrimos = 0;
int numero = 2;

while (contadorPrimos < 10)
{
  bool esPrimo = true;

  for (int i = 2; i < numero; i++)
  {
      if (numero % i == 0)
      {
        esPrimo = false;
        break;
      }
      
  }

  if (esPrimo)
  {

    Console.WriteLine($"El Numero {numero} es Primo");
    contadorPrimos++;


  }

  numero++;

}

Console.Read();
