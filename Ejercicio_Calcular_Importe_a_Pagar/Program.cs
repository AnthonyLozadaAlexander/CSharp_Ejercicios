Console.WriteLine("Calcular el importe a pagar por las horas trabajadas durante la semana, a una persona que se le paga por hora trabajada._ Pero debes calcular el sueldo de los 10 empleados de la compañia");

Console.WriteLine("---------------------------------------");

int Horas;
int Sueldo;


for (int i = 1; i <= 10; i++)
{
  Console.Write("Ingrese las horas trabajadas por el empleado " + i + ": ");
  Horas = Convert.ToInt32(Console.ReadLine());

  Console.Write("Ingrese el sueldo por hora trabajada por el empleado " + i + ": ");
  Sueldo = Convert.ToInt32(Console.ReadLine());

  double Resultado = Sueldo * Horas;

  Console.WriteLine("-------------------------------------------------");

  Console.WriteLine("El sueldo del empleado " + i + " es: " + Resultado);

  Console.WriteLine("-------------------------------------------------");
  
}

Console.Read();
