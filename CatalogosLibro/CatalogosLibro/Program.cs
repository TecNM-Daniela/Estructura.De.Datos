// Programa que muestra un catálogo de libros.
// Permite registrar información, mostrarla y determinar si está disponible.
using System;

class Libro
{
    // Atributos privados
    private string isbn;
    private string titulo;
    private string autor;
    private int anio;
    private bool disponible;

    // Método para registrar un libro
    public void RegistrarLibro(string isbn, string titulo, string autor, int anio, bool disponible)
    {
        this.isbn = isbn;
        this.titulo = titulo;
        this.autor = autor;
        this.anio = anio;
        this.disponible = disponible;
    }

    // Método para mostrar los datos
    public void MostrarLibro()
    {
        Console.WriteLine("\n=== DATOS DEL LIBRO ===");
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anio);

        if (disponible)
        {
            Console.WriteLine("Disponibilidad: Disponible :D");
        }
        else
        {
            Console.WriteLine("Disponibilidad: Prestado");
        }

        if (EsReciente())
        {
            Console.WriteLine("Este libro es reciente (2020 en adelante).");
        }
        else
        {
            Console.WriteLine("Este libro no es reciente.");
        }
    }

    // Método para determinar si el libro es reciente
    public bool EsReciente()
    {
        return anio >= 2020;
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        Libro libro = new Libro();

        Console.WriteLine("==========================");
        Console.WriteLine("=== CATÁLOGO DE LIBROS ===");
        Console.WriteLine("==========================");

        Console.Write("Ingrese el ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Ingrese el Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese el Autor: ");
        string autor = Console.ReadLine();

        int anio;

        // Validar año
        do
        {
            Console.Write("Ingrese el año de publicación: ");
            if (!int.TryParse(Console.ReadLine(), out anio))
            {
                anio = 0;
            }
            if (anio <= 0)
            {
                Console.WriteLine("Ingrese un año válido.");
            }
        } while (anio <= 0);

        bool disponible = false;

        // Preguntar disponibilidad
        while (true)
        {
            Console.Write("¿El libro está disponible? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToUpper();

            if (respuesta == "S")
            {
                disponible = true;
                break;
            }
            else if (respuesta == "N")
            {
                disponible = false;
                break;
            }
            else
            {
                Console.WriteLine("Respuesta inválida. Escriba 'S' o 'N'.");
            }
        }

        // Registrar y mostrar datos
        libro.RegistrarLibro(isbn, titulo, autor, anio, disponible);
        libro.MostrarLibro();
    }
}
