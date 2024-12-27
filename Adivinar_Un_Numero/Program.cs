int numeroSecreto = 8;
int numeroIngresado;
bool intentoBool = false;

Console.WriteLine("Adivinar el Numero (entre el 1 y el 10)");
Console.WriteLine("Pista: Es un numero par multiplicado por 4");
Console.WriteLine("----------------------------------------");
while (!intentoBool)
{
  Console.Write("Introduce un numero: ");
  numeroIngresado = Convert.ToInt32(Console.ReadLine());

  if (numeroIngresado < numeroSecreto)
  {
    Console.WriteLine("Demasiado Bajo, Intentalo Denuevo");
    Console.WriteLine("");
  }

  else if (numeroIngresado > numeroSecreto)
  {
    Console.WriteLine("Demasiado Alto, Intentalo Denuevo");
    Console.WriteLine("");
  }
  else
  {
    Console.WriteLine("Felicidades, Adivinaste el numero");
    intentoBool = true;
  }

}

Console.WriteLine("Press a key to exit");
Console.ReadKey();