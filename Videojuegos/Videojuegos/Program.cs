using System;

namespace InventarioVideojuegos
{
    class Videojuego
    {
        // Atributos
        private string nombre;
        private int codigo;
        private int precio;
        private int cantidad;

        // Metodo para registrar videojuegos
        public void RegistrarVideojuego(string nombre, int codigo, int precio, int cantidad)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // Metodo para mostrar informacion
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Codigo: {codigo}");
            Console.WriteLine($"Precio: ${precio}");
            Console.WriteLine($"Cantidad disponible: {cantidad}");
        }

        // Obtener codigo
        public int ObtenerCodigo()
        {
            return codigo;
        }

        // Obtener nombre
        public string ObtenerNombre()
        {
            return nombre;
        }

        // Validar codigo
        public string ValidarCodigo()
        {
            if (codigo < 0)
                return "El codigo no puede ser negativo.";
            else
                return "El codigo es valido.";
        }

        // Validar precio
        public string ValidarPrecio()
        {
            if (precio < 0)
                return "El precio no puede ser negativo.";
            else
                return "El precio es valido.";
        }

        // Validar cantidad
        public string ValidarCantidad()
        {
            if (cantidad < 0)
                return "La cantidad no puede ser negativa.";
            else
                return "La cantidad es valida.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear arreglo para guardar videojuegos
            Videojuego[] videojuegos = new Videojuego[100];

            // Contador de elementos utilizados
            int cantidadUtilizada = 0;
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=========== INVENTARIO DE VIDEOJUEGOS ===========");
                Console.WriteLine("1. Insertar videojuego");
                Console.WriteLine("2. Mostrar videojuegos");
                Console.WriteLine("3. Buscar videojuego");
                Console.WriteLine("4. Eliminar videojuego");
                Console.WriteLine("5. Ordenar videojuegos");
                Console.WriteLine("6. Mostrar cantidad de elementos utilizados");
                Console.WriteLine("7. Salir");
                Console.WriteLine("=================================================");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion no valida.");
                    Console.ReadKey();
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        // INSERTAR VIDEOJUEGO
                        Console.Clear();
                        Console.WriteLine("=========== INSERTAR VIDEOJUEGO ===========");

                        if (cantidadUtilizada == videojuegos.Length)
                        {
                            Console.WriteLine("El arreglo esta lleno.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Ingrese el nombre del videojuego: ");
                        string nombre = Console.ReadLine();

                        int codigo;
                        do
                        {
                            Console.Write("Ingrese el codigo: ");

                            if (!int.TryParse(Console.ReadLine(), out codigo))
                                codigo = -1;

                            if (codigo < 0)
                                Console.WriteLine("El codigo no puede ser negativo.");

                        } while (codigo < 0);

                        // Verificar si el codigo ya existe
                        bool repetido = false;

                        for (int i = 0; i < cantidadUtilizada; i++)
                        {
                            if (videojuegos[i].ObtenerCodigo() == codigo)
                                repetido = true;
                        }

                        if (repetido)
                        {
                            Console.WriteLine("Ese codigo ya esta registrado.");
                            Console.ReadKey();
                            break;
                        }

                        int precio;
                        do
                        {
                            Console.Write("Ingrese el precio: $");

                            if (!int.TryParse(Console.ReadLine(), out precio))
                                precio = -1;

                            if (precio < 0)
                                Console.WriteLine("El precio no puede ser negativo.");

                        } while (precio < 0);

                        int cantidad;
                        do
                        {
                            Console.Write("Ingrese la cantidad disponible: ");

                            if (!int.TryParse(Console.ReadLine(), out cantidad))
                                cantidad = -1;

                            if (cantidad < 0)
                                Console.WriteLine("La cantidad no puede ser negativa.");

                        } while (cantidad < 0);

                        // Crear y registrar videojuego
                        Videojuego nuevoVideojuego = new Videojuego();

                        nuevoVideojuego.RegistrarVideojuego(
                            nombre, codigo, precio, cantidad);

                        // Insertar en el arreglo
                        videojuegos[cantidadUtilizada] = nuevoVideojuego;
                        cantidadUtilizada++;

                        Console.WriteLine();
                        Console.WriteLine("Videojuego agregado correctamente.");
                        Console.ReadKey();
                        break;

                    case 2:
                        // MOSTRAR VIDEOJUEGOS
                        Console.Clear();
                        Console.WriteLine("=========== VIDEOJUEGOS REGISTRADOS ===========");

                        if (cantidadUtilizada == 0)
                        {
                            Console.WriteLine("No hay videojuegos registrados.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadUtilizada; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Videojuego " + (i + 1));
                                videojuegos[i].MostrarInformacion();
                                Console.WriteLine("--------------------------------------------");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        // BUSCAR VIDEOJUEGO
                        Console.Clear();
                        Console.WriteLine("=========== BUSCAR VIDEOJUEGO ===========");

                        Console.Write("Ingrese el codigo del videojuego: ");

                        if (!int.TryParse(Console.ReadLine(), out int codigoBuscar))
                        {
                            Console.WriteLine("Codigo no valido.");
                            Console.ReadKey();
                            break;
                        }

                        bool encontrado = false;

                        for (int i = 0; i < cantidadUtilizada; i++)
                        {
                            if (videojuegos[i].ObtenerCodigo() == codigoBuscar)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Videojuego encontrado:");
                                videojuegos[i].MostrarInformacion();
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                            Console.WriteLine("Videojuego no encontrado.");

                        Console.ReadKey();
                        break;

                    case 4:
                        // ELIMINAR VIDEOJUEGO
                        Console.Clear();
                        Console.WriteLine("=========== ELIMINAR VIDEOJUEGO ===========");

                        Console.Write("Ingrese el codigo del videojuego: ");

                        if (!int.TryParse(Console.ReadLine(), out int codigoEliminar))
                        {
                            Console.WriteLine("Codigo no valido.");
                            Console.ReadKey();
                            break;
                        }

                        int posicion = -1;

                        for (int i = 0; i < cantidadUtilizada; i++)
                        {
                            if (videojuegos[i].ObtenerCodigo() == codigoEliminar)
                            {
                                posicion = i;
                                break;
                            }
                        }

                        if (posicion != -1)
                        {
                            // Recorrer los elementos para llenar el espacio
                            for (int i = posicion; i < cantidadUtilizada - 1; i++)
                            {
                                videojuegos[i] = videojuegos[i + 1];
                            }

                            cantidadUtilizada--;
                            videojuegos[cantidadUtilizada] = null;

                            Console.WriteLine("Videojuego eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Videojuego no encontrado.");
                        }

                        Console.ReadKey();
                        break;

                    case 5:
                        // ORDENAR VIDEOJUEGOS POR NOMBRE
                        Console.Clear();
                        Console.WriteLine("=========== ORDENAR VIDEOJUEGOS ===========");

                        if (cantidadUtilizada == 0)
                        {
                            Console.WriteLine("No hay videojuegos para ordenar.");
                        }
                        else
                        {
                            // Ordenar alfabeticamente
                            for (int i = 0; i < cantidadUtilizada - 1; i++)
                            {
                                for (int j = 0; j < cantidadUtilizada - 1 - i; j++)
                                {
                                    if (string.Compare(
                                        videojuegos[j].ObtenerNombre(),
                                        videojuegos[j + 1].ObtenerNombre(),
                                        StringComparison.OrdinalIgnoreCase) > 0)
                                    {
                                        Videojuego temporal = videojuegos[j];
                                        videojuegos[j] = videojuegos[j + 1];
                                        videojuegos[j + 1] = temporal;
                                    }
                                }
                            }

                            Console.WriteLine("Videojuegos ordenados por nombre:");

                            for (int i = 0; i < cantidadUtilizada; i++)
                            {
                                videojuegos[i].MostrarInformacion();
                                Console.WriteLine("--------------------------------------------");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 6:
                        // MOSTRAR CANTIDAD DE ELEMENTOS UTILIZADOS
                        Console.Clear();
                        Console.WriteLine("=========== CANTIDAD DE VIDEOJUEGOS ===========");
                        Console.WriteLine("Elementos utilizados: " + cantidadUtilizada);
                        Console.WriteLine("Capacidad del arreglo: " + videojuegos.Length);
                        Console.WriteLine("Espacios disponibles: " +
                            (videojuegos.Length - cantidadUtilizada));

                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 7);
        }
    }
}
