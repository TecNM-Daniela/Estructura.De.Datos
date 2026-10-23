using System;

namespace ConversorUnidades
{
    // TDA: Conversor de Unidades
    class Conversor
    {
        // Método para convertir Metros a Kilómetros
        public double MetrosAKilometros(double metros)
        {
            return metros / 1000;
        }

        // Método para convertir Kilómetros a Metros
        public double KilometrosAMetros(double kilometros)
        {
            return kilometros * 1000;
        }

        // Método para convertir Centímetros a Metros
        public double CentimetrosAMetros(double centimetros)
        {
            return centimetros / 100;
        }

        // Método para convertir Metros a Centímetros
        public double MetrosACentimetros(double metros)
        {
            return metros * 100;
        }

        // Método para convertir Kilogramos a Gramos
        public double KilogramosAGramos(double kilogramos)
        {
            return kilogramos * 1000;
        }

        // Método para convertir Gramos a Kilogramos
        public double GramosAKilogramos(double gramos)
        {
            return gramos / 1000;
        }

        // Método para convertir Celsius a Fahrenheit
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Método para convertir Fahrenheit a Celsius
        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

class Program
{
    // Método para mostrar el menú
    static void MostrarMenu()
    {
        Console.Clear();

        Console.WriteLine("==============================");
        Console.WriteLine("=== Conversor de Unidades ====");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Metros - Kilómetros");
        Console.WriteLine("2. Kilómetros - Metros");
        Console.WriteLine("3. Centímetros - Metros");
        Console.WriteLine("4. Metros - Centímetros");
        Console.WriteLine("5. Kilogramos - Gramos");
        Console.WriteLine("6. Gramos - Kilogramos");
        Console.WriteLine("7. Celsius - Fahrenheit");
        Console.WriteLine("8. Fahrenheit - Celsius");
        Console.WriteLine("9. Salir");
        Console.WriteLine("==============================");
        Console.Write("Seleccione una opción: ");
    }

    // Método para pedir la opción
    static int PedirOpcion()
    {
        int opcion;

        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Opción no válida.");
            Console.Write("Ingrese nuevamente la opción: ");
        }

        return opcion;
    }

    // Método para pedir el número
    static double PedirNumero()
    {
        double numero;

        Console.Write("\nIngrese el valor a convertir: ");

        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido.");
            Console.Write("Ingrese nuevamente el valor: ");
        }

        return numero;
    }

    // Método para pausar el programa
    static void Pausar()
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }

    // Método para realizar las conversiones
    static void RealizarConversion(
        ConversorUnidades.Conversor conversor,
        int opcion)
    {
        double numero = PedirNumero();
        double resultado = 0;
        string unidad = "";

        switch (opcion)
        {
            case 1:
                resultado = conversor.MetrosAKilometros(numero);
                unidad = " km";
                break;

            case 2:
                resultado = conversor.KilometrosAMetros(numero);
                unidad = " m";
                break;

            case 3:
                resultado = conversor.CentimetrosAMetros(numero);
                unidad = " m";
                break;

            case 4:
                resultado = conversor.MetrosACentimetros(numero);
                unidad = " cm";
                break;

            case 5:
                resultado = conversor.KilogramosAGramos(numero);
                unidad = " g";
                break;

            case 6:
                resultado = conversor.GramosAKilogramos(numero);
                unidad = " kg";
                break;

            case 7:
                resultado = conversor.CelsiusAFahrenheit(numero);
                unidad = " °F";
                break;

            case 8:
                resultado = conversor.FahrenheitACelsius(numero);
                unidad = " °C";
                break;
        }

        Console.WriteLine("\nResultado: " + resultado + unidad);
        Pausar();
    }

    // Programa principal
    static void Main(string[] args)
    {
        // Crear objeto conversor
        ConversorUnidades.Conversor conversor =
            new ConversorUnidades.Conversor();

        int opcion;

        do
        {
            MostrarMenu();

            opcion = PedirOpcion();

            // Opciones de conversión
            if (opcion >= 1 && opcion <= 8)
            {
                RealizarConversion(conversor, opcion);
            }

            // Salir
            else if (opcion == 9)
            {
                Console.WriteLine("\nSaliendo del conversor...");
            }

            // Opción no válida
            else
            {
                Console.WriteLine("\nOpción no válida.");
                Pausar();
            }

        } while (opcion != 9);
    }
}
