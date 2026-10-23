using System;

class Contacto
{
    //Atributos privador
    private string nombre;
    private string telefono;
    private string correo;

    //Metodo registrar datos

    public void RegistrarContacto(string nombre, string telefono, string correo)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
    }
    //Metodo para mostrar datos
    public void MostrarContactos()
    {
        Console.WriteLine("Datos del contacto");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Correo: " + correo);
    }
    //Metodo para buscar por nombre
    public bool BuscarContacto(string nombreBuscado)
    {
        return nombre.ToLower() == nombreBuscado.ToLower();
    }

}

class Program
{
    static void Main()
    {
        Contacto contacto = new Contacto();
        Console.WriteLine("Agenda de contactos");
        Console.WriteLine("Ingresa el nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingresa el teléfono: ");
        string telefono = Console.ReadLine();

        Console.WriteLine("Ingresa el correo: ");
        string correo = Console.ReadLine();

        //Registrar contacto

        contacto.RegistrarContacto(nombre, telefono, correo);

        //Mostrar contacto

        contacto.MostrarContactos();

        //Buscar contacto

        Console.Write("\nIngresar un nombre para buscar: ");
        string nombreBuscado = Console.ReadLine();
        if (contacto.BuscarContacto(nombreBuscado))
        {
            Console.WriteLine("Contacto encontrado");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado");
        }
        Console.WriteLine("\nPresione una letra para salir");
        Console.ReadKey();
    }


}