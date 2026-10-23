using System;

namespace CalculadoraBasica
{
    // TDA: Calculadora
    class Calculadora
    {
        // Método para sumar
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        // Método para restar
        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        // Método para multiplicar
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        // Método para dividir
        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error. No se puede dividir entre 0");
                return 0;
            }

            return num1 / num2;
        }

        // Método para potencia
        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        // Método para raíz cuadrada
        public double Raiz(double num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine("Error. No se puede sacar raíz de un número negativo");
                return 0;
            }

            return Math.Sqrt(num1);
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
        Console.WriteLine("===== Calculadora Básica =====");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Potencia");
        Console.WriteLine("6. Raíz cuadrada");
        Console.WriteLine("7. Salir");
        Console.WriteLine("==============================");
        Console.Write("Seleccione una opción: ");
    }

    // Método para pedir un número
    static double PedirNumero(string mensaje)
    {
        double numero;

        Console.Write(mensaje);

        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido.");
            Console.Write("Ingrese nuevamente: ");
        }

        return numero;
    }

    // Método para pausar el programa
    static void Pausar()
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }

    // Método para realizar operaciones con dos números
    static void OperacionDosNumeros(
        CalculadoraBasica.Calculadora calculadora,
        int opcion)
    {
        double num1 = PedirNumero("\nIngrese el primer número: ");
        double num2 = PedirNumero("Ingrese el segundo número: ");

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = calculadora.Sumar(num1, num2);
                break;

            case 2:
                resultado = calculadora.Restar(num1, num2);
                break;

            case 3:
                resultado = calculadora.Multiplicar(num1, num2);
                break;

            case 4:
                resultado = calculadora.Dividir(num1, num2);
                break;

            case 5:
                resultado = calculadora.Potencia(num1, num2);
                break;
        }

        Console.WriteLine("\nResultado: " + resultado);
        Pausar();
    }

    // Método para realizar la raíz cuadrada
    static void OperacionRaiz(CalculadoraBasica.Calculadora calculadora)
    {
        double num1 = PedirNumero("\nIngrese el número: ");

        double resultado = calculadora.Raiz(num1);

        Console.WriteLine("\nResultado: " + resultado);
        Pausar();
    }

    // Programa principal
    static void Main(string[] args)
    {
        CalculadoraBasica.Calculadora calculadora =
            new CalculadoraBasica.Calculadora();

        int opcion;

        do
        {
            MostrarMenu();

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("\nOpción no válida");
                Pausar();
                continue;
            }

            // Operaciones que necesitan dos números
            if (opcion >= 1 && opcion <= 5)
            {
                OperacionDosNumeros(calculadora, opcion);
            }

            // Raíz cuadrada
            else if (opcion == 6)
            {
                OperacionRaiz(calculadora);
            }

            // Salir
            else if (opcion == 7)
            {
                Console.WriteLine("\nSaliendo de la calculadora...");
            }

            // Opción no válida
            else
            {
                Console.WriteLine("\nOpción no válida");
                Pausar();
            }

        } while (opcion != 7);
    }
}