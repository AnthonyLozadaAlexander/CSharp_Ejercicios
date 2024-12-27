//? Factorial de un numero

Console.Write("Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

int Factorial = 1;

for (int i = 1; i <= numero; i++)
{

  Factorial = Factorial * i;

}

Console.WriteLine("El factorial de " + numero + " es: " + Factorial);

Console.WriteLine("----------------------------------------");
Console.WriteLine("Press a Button to Exit");
Console.ReadKey();