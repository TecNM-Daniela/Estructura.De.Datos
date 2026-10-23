using System;
class Hospital
{
    //atributos privadeishons
    private int id;
    private string nombre;
    private string estado;
    private int edad;
    private int habitacion;

    //registrar al malito
    public void RegistrarPaciente(int id, string nombre, string estado, int edad, int habitacion)
    {
        this.id = id;
        this.nombre = nombre;
        this.estado = estado;
        this.edad = edad;
        this.habitacion = habitacion;
    }

    //mostrar datos
    public void MostrarPaciente()
    {
        Console.WriteLine("\n=== Datos del Paciente");
        Console.WriteLine("ID del Paciente:" + id);
        Console.WriteLine("Nombre del paciente:" + nombre);
        Console.WriteLine("Estado del Paciente:" + estado);
        Console.WriteLine("Edad del paciente:" + edad);
        Console.WriteLine("Habitacion asignada:" + habitacion);
    }
    public bool BuscarID(int idBuscado)
    {
        return this.id == idBuscado;
    }

}

class Programa
{
    static void Main()
    {
        Hospital hospital = new Hospital();

        Console.WriteLine("========== Pacientes ================");

        Console.Write("Ingrese el ID del Paciente: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Nombre del Paciente: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la Edad del Paciente: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Estado del Paciente: ");
        string estado = Console.ReadLine();

        Console.Write("Ingrese la Habitación del Paciente: ");
        int habitacion = int.Parse(Console.ReadLine());

        // Registrar y mostrar
        hospital.RegistrarPaciente(id, nombre, estado, edad, habitacion);
        hospital.MostrarPaciente();

        // Ejemplo de búsqueda
        Console.Write("\nIngrese un ID para buscar: ");
        int idBuscado = int.Parse(Console.ReadLine());

        if (hospital.BuscarID(idBuscado))
        {
            Console.WriteLine("Paciente encontrado:");
            hospital.MostrarPaciente();
        }
        else
        {
            Console.WriteLine("No se encontró un paciente con ese ID.");
        }


        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}989