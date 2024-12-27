// Escribe un programa que muestre por consola (con un print) los numeros de 1 al 100 (ambos incluidos y con un salto de linea entre cada impresion), sustituyendo los siguientes:

// - Multiplos de 3 por la palabra "Fizz".
// - Multiplos de 5 por la palabra "Buzz".
// - Multiplos de 3 y de 5 a la vez por la palabra "FizzBuzz".

Console.WriteLine("---------------------------------------");

Console.WriteLine("Ejercicio Fizz");

Console.WriteLine("---------------------------------------");


for (int i = 1; i <= 100; i++)
{

  if (i % 3 == 0)
  {

  Console.WriteLine("Fizz Sustituyendo multiplos de 3");
  Console.WriteLine("");

  }
  else
  {

  Console.WriteLine(i);
  Console.WriteLine("");

  }
}

Console.WriteLine("---------------------------------------");

Console.WriteLine("Ejercicio Buzz");

Console.WriteLine("---------------------------------------");


for (int i = 1; i <= 100; i++)
{

  if (i % 5 == 0)
  {


  Console.WriteLine("Buzz Sustituyendo multiplos de 5");
  Console.WriteLine("");


  }

  else
  {

  Console.WriteLine(i);
  Console.WriteLine("");

  }

}

Console.WriteLine("---------------------------------------");

Console.WriteLine("Ejercicio FizzBuzz");

Console.WriteLine("---------------------------------------");

for (int i = 1; i <= 100; i++)
{

  if (i % 3 == 0 && i % 5 == 0)
  {

   Console.WriteLine("FizzBuzz Sustituyendo multiplos de 3 y 5");
   Console.WriteLine("");


  }
  else
  {
    Console.WriteLine(i);
    Console.WriteLine("");
  }

}

Console.Read();

