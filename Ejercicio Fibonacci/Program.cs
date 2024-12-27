Console.WriteLine("Algoritmo Fibonacci");
Console.WriteLine("-------------------");

Console.Write("Cuantos numeros desea ingresar?: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

  Fibonacci(cantidad); 

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
