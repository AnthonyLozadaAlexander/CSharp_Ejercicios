using System;
namespace Ejercicios_Sistema_NIP
{
  class Program
  {
    static void Main(string[] args)
    {
      int pin = 3867, userPin = 0, intentos = 4, opc = 0; // variables
      decimal userSaldo = 4000, montoRetiro = 0; // variables
      List<string> listaMovimientos = new List<string>(); // lista de movimientos

      Console.WriteLine("Bienvenido al Cajero Automatico");
      Console.WriteLine("Ingrese su PIN: ");
      Console.WriteLine();
      Console.WriteLine("Porfavor, Ingrese su NIP de 4 Digitos");
      Console.WriteLine("-------------------------------------");
      userPin = Convert.ToInt32(Console.ReadLine());

      //* != significa no es igual.
      while (userPin != pin)
      {

        intentos--;
        if (intentos == 0)
        {
          Environment.Exit(0);
        }

        Console.WriteLine();
        Console.WriteLine("NIP Incorrecto,Por favor ingrese nuevamente su nip de 4 digitos. Te restan {0} intentos", (intentos).ToString());

        userPin = Convert.ToInt32(Console.ReadLine());

      }
      do
      {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Porfavor selecciona una opcion:");
        Console.WriteLine();
        Console.WriteLine("1 Consultar Saldo");
        Console.WriteLine("2 Retiro de Efectivo");
        Console.WriteLine("3 Consultar Movimientos");
        Console.WriteLine("4 Salir");
        Console.WriteLine("-------------------------------------");
        opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (opc)
        {
          case 1:
           Console.WriteLine("Tu saldo es: $" + userSaldo);
           listaMovimientos.Add("Consulta de Saldo: " + userSaldo.ToString() + ") fecha: " + DateTime.Now);
           break;
          case 2:
            Console.WriteLine("Ingrese el monto a retirar: ");
            montoRetiro = Convert.ToInt32(Console.ReadLine());
            if (montoRetiro > userSaldo)
            {
              Console.WriteLine();
              Console.WriteLine("El monto de retiro debe ser menor a tu saldo actual (${0})", userSaldo.ToString());
            }
            else
            {
              Console.WriteLine();
              userSaldo = userSaldo - montoRetiro;
              Console.WriteLine("Retiro exitoso, tu saldo actual es: $" + userSaldo);
              listaMovimientos.Add("Retiro de: " + montoRetiro.ToString() + ") fecha: " + DateTime.Now);
            }
            break;
          case 3:
            Console.WriteLine("Estos son tus ultimos movimientos: ");
            Console.WriteLine();
            for (int i = listaMovimientos.Count - 1; i >= 0; i--) // i-- decrementar
            {
              Console.WriteLine(listaMovimientos[i]);
              Console.WriteLine();
            }
            Console.ReadKey();
            break;

          case 4:
            break;
          default:
            Console.WriteLine("Opcion Incorrecta, saliendo del sistema");
            Console.ReadKey();
            break;
        }

      } while (opc != 4);

    }

  }
}


