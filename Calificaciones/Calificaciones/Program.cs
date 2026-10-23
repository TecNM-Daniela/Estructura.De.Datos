using System;
class Alumno
{
    // Atributos
    private string nombre;
    private string matricula;
    private double calificacion1;
    private double calificacion2;
    private double calificacion3;

    // Método para registrar los datos
    public void RegistrarDatos(string nombre, string matricula, double calificacion1, double calificacion2, double calificacion3)
    {
        this.nombre = nombre;
        this.matricula = matricula;
        this.calificacion1 = calificacion1;
        this.calificacion2 = calificacion2;
        this.calificacion3 = calificacion3;
    }

    // Método para calcular el promedio
    public double CalcularPromedio()
    {
        return (calificacion1 + calificacion2 + calificacion3) / 3;
    }

    // Método para determinar si aprobó
    public bool Aprobo()
    {
        return CalcularPromedio() >= 70;
    }

    // Método para mostrar los datos
    public void MostrarDatos()
    {
        Console.WriteLine("\n---- DATOS DEL ALUMNO ----");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Matrícula: " + matricula);

        Console.WriteLine("\nCALIFICACIONES:");
        Console.WriteLine("Calificación 1: " + calificacion1);
        Console.WriteLine("Calificación 2: " + calificacion2);
        Console.WriteLine("Calificación 3: " + calificacion3);

        Console.WriteLine("\nPromedio: " + CalcularPromedio().ToString("F2"));

        if (Aprobo())
        {
            Console.WriteLine("Resultado: Aprobado");
        }
        else
        {
            Console.WriteLine("Resultado: Reprobado");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Alumno alumno = new Alumno();

        Console.WriteLine("===== Sistema de calificaciones =====");

        Console.WriteLine("Ingrese los datos del alumno:");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        // Validar la calificación 1
        do
        {
            Console.WriteLine("Ingrese la calificación 1:");

            if (!double.TryParse(Console.ReadLine(), out calificacion1))
            {
                calificacion1 = -1;
            }

            if (calificacion1 < 0 || calificacion1 > 100)
            {
                Console.WriteLine("Calificación inválida. Debe estar entre 0 y 100.");
            }

        } while (calificacion1 < 0 || calificacion1 > 100);


        // Validar la calificación 2
        do
        {
            Console.WriteLine("Ingrese la calificación 2:");

            if (!double.TryParse(Console.ReadLine(), out calificacion2))
            {
                calificacion2 = -1;
            }

            if (calificacion2 < 0 || calificacion2 > 100)
            {
                Console.WriteLine("Calificación inválida. Debe estar entre 0 y 100.");
            }

        } while (calificacion2 < 0 || calificacion2 > 100);


        // Validar la calificación 3
        do
        {
            Console.WriteLine("Ingrese la calificación 3:");

            if (!double.TryParse(Console.ReadLine(), out calificacion3))
            {
                calificacion3 = -1;
            }

            if (calificacion3 < 0 || calificacion3 > 100)
            {
                Console.WriteLine("Calificación inválida. Debe estar entre 0 y 100.");
            }

        } while (calificacion3 < 0 || calificacion3 > 100);


        // Registrar alumno
        alumno.RegistrarDatos(
            nombre,
            matricula,
            calificacion1,
            calificacion2,
            calificacion3);

        // Mostrar Datos
        alumno.MostrarDatos();

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}