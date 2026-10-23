// Programa que permite registrar los datos de una alumno y obtener informacion academica a partit de sus calificaciones
using System;
class Alumno
{
    // Declaracion de los atributos privados
    private string matricula;
    private string nombreAlumno;
    private string carrera;
    private int semestre;
    private double promedio;

    // Metodo para registrar los datos del alumno
    public void RegistrarAlumno(string matricula, string nombreAlumno, string carrera, int semestre, double promedio)
    {
        this.matricula = matricula;
        this.nombreAlumno = nombreAlumno;
        this.carrera = carrera;
        this.semestre = semestre;
        this.promedio = promedio;
    }

    // Metodo para mostrar los datos del alumno
    public void MostrarAlumno()
    {
        Console.WriteLine("\n=== DATOS DEL ALUMNO ===");
        Console.WriteLine("Número de control del alumno: " + matricula);
        Console.WriteLine("Nombre completo del alumno: " + nombreAlumno);
        Console.WriteLine("Carrera del alumno: " + carrera);
        Console.WriteLine("Semestre actual del alumno: " + semestre);
        Console.WriteLine("Promedio del alumno: " + promedio.ToString("F2"));

        if (EstaAprobado())
        {
            Console.WriteLine("Estado: Aprobado :D");
        }
        else
        {
            Console.WriteLine("Estado: Reprobado :(");
        }
    }

    // Metodo para verificar si el alumno esta aprobado o reprobado 
    public bool EstaAprobado()
    {
        return promedio >= 70;
    }

    // Metodo para determinar el desempeño
    public string ObtenerDesempenio()
    {
        if (promedio >= 90)
        {
            return "Excelente";
        }
        else if (promedio >= 80)
        {
            return "Bueno";
        }
        else if (promedio >= 70)
        {
            return "Regular";
        }
        else
        {
            return "Insuficiente";
        }

    }

}

// Porgrama principal
class Programa
{
    static void Main()
    {
        Alumno alumno = new Alumno();

        Console.WriteLine("==========================");
        Console.WriteLine("=== CONTROL DE ALUMNOS ===");
        Console.WriteLine("==========================");

        Console.Write("Ingrese la matricula del alumno: ");
        string matricula = Console.ReadLine();
        Console.Write("Ingrese el nombre del alumno: ");
        string nombreAlumno = Console.ReadLine();
        Console.Write("Ingrese la carrera del alumno: ");
        string carrera = Console.ReadLine();

        // Validar semestre
        int semestre;
        do
        {
            Console.Write("Ingrese el semestre actual del alumno: ");
            if (!int.TryParse(Console.ReadLine(), out semestre))
            {
                semestre = 0;
            }
            if (semestre < 1 || semestre > 12)
            {
                Console.WriteLine("Semestre no valido. Debe ser de 1 a 12");
            }
        } while (semestre < 1 || semestre > 12);

        // Validar el promedio del alumno
        double promedio;
        do
        {
            Console.Write("Ingrese el promedio del alumno: ");
            if (!double.TryParse(Console.ReadLine(), out promedio))
            {
                promedio = -1;
            }
            if (promedio < 0 || promedio > 100)
            {
                Console.WriteLine("El promedio debe de estar entre 0 y 100");
            }
        } while (promedio < 0 || promedio > 100);

        alumno.RegistrarAlumno(matricula, nombreAlumno, carrera, semestre, promedio);
        alumno.MostrarAlumno();
        Console.WriteLine("Desempeño academico:" + alumno.ObtenerDesempenio());

        Console.Write("\nPresione una tecla para salir");
        Console.ReadKey();
    }
}