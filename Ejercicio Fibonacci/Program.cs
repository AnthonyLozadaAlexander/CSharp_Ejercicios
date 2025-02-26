Console.WriteLine("Algoritmo Fibonacci");
Console.WriteLine("-------------------");

Console.Write("Ingrese hasta que numero desea la secuencia: ");
int n = Convert.ToInt32(Console.ReadLine());

  Fibonacci(n); 

static void Fibonacci(int n)
{
  int a = 0, b = 1, c = 0;

  Console.WriteLine("Secuencia Fibonacci:");

  for (int i = 0; i < n; i++)
  {
    Console.Write(a + " ");
   
    c = a + b;
    a = b;
    b = c;

  }
  
}

Console.ReadKey();
