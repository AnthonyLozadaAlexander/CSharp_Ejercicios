//? Registra la calificacion de N alumnos e imprime en pantalla el alumno con el peor promedio y el alumno con el mejor promedio.

Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Registra la calificacion de 4 alumnos e imprime en pantalla el alumno con el peor promedio y el alumno con el mejor promedio.");
Console.WriteLine("------------------------------------------------------------------------");

// Variables para almacenar datos de alumnos
double[] calificaciones = new double[4]; // Array para almacenar calificaciones [4]
string[] nombres = new string[4]; // array para almacenar nombres [4]

// Solicitar datos de cada alumno
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("------------------------------------");
    Console.Write($"Ingresa el nombre del alumno {i + 1}: ");
    nombres[i] = Console.ReadLine();

    Console.Write("Ingresa la calificación: ");
    calificaciones[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("------------------------------------");
}

// Determinar el mejor y peor promedio
double mejorPromedio = calificaciones[0];
double peorPromedio = calificaciones[0];
int indiceMejor = 0;
int indicePeor = 0;

for (int i = 1; i < 4; i++)
{
    if (calificaciones[i] > mejorPromedio)
    {
        mejorPromedio = calificaciones[i];
        indiceMejor = i;
    }
    if (calificaciones[i] < peorPromedio)
    {
        peorPromedio = calificaciones[i];
        indicePeor = i;
    }
}

// Imprimir resultados
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"El alumno con el mejor promedio es: {nombres[indiceMejor]} con {mejorPromedio}");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"El alumno con el peor promedio es: {nombres[indicePeor]} con {peorPromedio}");
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Presiona cualquier tecla para continuar...");
Console.ReadKey();







