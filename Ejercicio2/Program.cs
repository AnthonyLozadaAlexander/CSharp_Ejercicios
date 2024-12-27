Console.WriteLine("Una persona ahorra $1000.000 en un banco que le ofrece una tasa de interes compuesto mensual del 2% ¿que valor recibira si la persona, si retira su dinero al cabo de 5 meses.");

Console.WriteLine("---------------------------------------------------------");

double Capital; //? 1.000.000
double interes; //? 0.02
int tiempo; //? 5 "meses"
double ValorFinal;
double CalculoPorcentajeInteres;
double intereElevadoMeses;

Console.Write("Ingrese el valor del capital a invertir: ");
Capital = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el porcentaje de interes mensual: ");
interes = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo en meses: ");
tiempo = Convert.ToInt32(Console.ReadLine());

//? el capital se multiplica por la potencia de la suma de 1 + el interes elevado al tiempo(a la quinta potencia)}

CalculoPorcentajeInteres = (interes / 100) + 1;
intereElevadoMeses = Math.Pow(CalculoPorcentajeInteres, tiempo);
ValorFinal = Capital * intereElevadoMeses;


Console.WriteLine("");

Console.WriteLine("El valor final es: " + ValorFinal);

Console.Read();

