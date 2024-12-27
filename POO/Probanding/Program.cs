int num1, num2, resultado;
string Operador;
resultado = 0;

Console.WriteLine("Calculadora Basica");
Console.WriteLine("-------------------");

Console.Write("Ingrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Ingrese el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.Write("Ingrese el operador: +, -, *, / ");
Operador = Console.ReadLine() ?? string.Empty;
bool operacionValida = true;

switch (Operador)
{
  case "+":
    resultado = (num1 + num2);
    Console.WriteLine($"El resultado de la suma de {num1} + {num2} es: {resultado}");
    break;

  case "-":
    resultado = (num1 - num2);
    Console.WriteLine($"El resultado de la resta de {num1} - {num2} es: {resultado}");
    break;

  case "*":
    resultado = (num1 * num2);
    Console.WriteLine($"El resultado de la multiplicacion de {num1} * {num2} es: {resultado}");
    break;

  case "/":
    if (num2 != 0)
    {
    resultado = (num1 / num2);
    Console.WriteLine($"El resultado de la division de {num1} / {num2} es: {resultado}");
    }
    else
    {
      Console.WriteLine("No se puede dividir por 0");
      operacionValida = false;
    }
    break;

  default:
    Console.WriteLine("Operador Incorrecto, ingrese un operador valido");
    operacionValida = false;
    break;
}

if (operacionValida)
{
  Console.WriteLine("Presione cualquier tecla para salir");
  Console.ReadKey();
}
else
{
  Console.WriteLine("Presione cualquier tecla para continuar");
  Console.ReadKey();
}
