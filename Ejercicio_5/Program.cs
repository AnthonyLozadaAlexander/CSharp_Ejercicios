Console.WriteLine("Ingresar Numeros del 1 al 10");
Console.WriteLine("----------------------------------------");

int contadorPar, numero, num, contadorImpar;

int i = 0;
contadorPar = 0;
contadorImpar = 0;
Console.Write("Ingrese Cuantos Numeros Desea Contar: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Usted Ingresara {numero} Numeros");
Console.WriteLine("----------------------------------------");

while (i < numero)
{
  Console.Write("Ingrese un numero: ");
  num = Convert.ToInt32(Console.ReadLine());

  if (num % 2 == 0) //* Verifica si el numero es par
  {
    contadorPar = contadorPar + 1; //* tambien se entiende como contador++; o contador += 1;
  }
  else if (num % 2 != 0)
  {
    contadorImpar = contadorImpar + 1;
  }

  i++; //* tambien se entiende como iteraciones++; o iteraciones += 1;
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("La cantidad de numeros pares es: " + contadorPar);
Console.WriteLine("----------------------------------------");

Console.WriteLine("----------------------------------------");
Console.WriteLine("La cantidad de numeros Impares es: " + contadorImpar);
Console.WriteLine("----------------------------------------");

Console.WriteLine("Press a Button to Exit");
Console.ReadKey();
