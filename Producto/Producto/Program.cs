using System;

namespace Productos
{
    class Productos
    {
        // Atributos
        private string nombre;
        private int codigo;
        private int precio;
        private int cantidad;
        private int total;

        // Método para registrar productos
        public void RegistrarProductos(string nombre, int codigo, int precio, int cantidad)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.total = CalcularTotal();
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total: {total}");
        }

        // Obtener código
        public int ObtenerCodigo()
        {
            return codigo;
        }

        // Validar código
        public string ValidarCodigo()
        {
            if (codigo < 0)
            {
                return "El código no puede ser negativo.";
            }
            else
            {
                return "El código es válido.";
            }
        }

        // Validar precio
        public string ValidarPrecio()
        {
            if (precio < 0)
            {
                return "El precio no puede ser negativo.";
            }
            else
            {
                return "El precio es válido.";
            }
        }

        // Validar cantidad
        public string ValidarCantidad()
        {
            if (cantidad < 0)
            {
                return "La cantidad no puede ser negativa.";
            }
            else
            {
                return "La cantidad es válida.";
            }
        }

        // Validar total
        public string ValidarTotal()
        {
            if (total < 0)
            {
                return "El total no puede ser negativo.";
            }
            else
            {
                return "El total es válido.";
            }
        }

        // Calcular total
        public int CalcularTotal()
        {
            return precio * cantidad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lista para guardar productos
            List<Productos> listaProductos = new List<Productos>();

            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=========== MENÚ DE PRODUCTOS ===========");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==========================================");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // AGREGAR PRODUCTO

                        Console.Clear();
                        Console.WriteLine("=========== AGREGAR PRODUCTO ===========");

                        string nombre;
                        int codigo;
                        int precio;
                        int cantidad;

                        // Nombre
                        Console.Write("Ingrese el nombre del producto: ");
                        nombre = Console.ReadLine();

                        // Código
                        do
                        {
                            Console.Write("Ingrese el código del producto: ");
                            codigo = int.Parse(Console.ReadLine());

                            if (codigo < 0)
                            {
                                Console.WriteLine("Error: el código no puede ser negativo.");
                            }

                        } while (codigo < 0);

                        // Precio
                        do
                        {
                            Console.Write("Ingrese el precio del producto: ");
                            precio = int.Parse(Console.ReadLine());

                            if (precio < 0)
                            {
                                Console.WriteLine("Error: el precio no puede ser negativo.");
                            }

                        } while (precio < 0);

                        // Cantidad
                        do
                        {
                            Console.Write("Ingrese la cantidad del producto: ");
                            cantidad = int.Parse(Console.ReadLine());

                            if (cantidad < 0)
                            {
                                Console.WriteLine("Error: la cantidad no puede ser negativa.");
                            }

                        } while (cantidad < 0);

                        // Crear producto
                        Productos nuevoProducto = new Productos();

                        nuevoProducto.RegistrarProductos(
                            nombre,
                            codigo,
                            precio,
                            cantidad
                        );

                        // Agregar producto a la lista
                        listaProductos.Add(nuevoProducto);

                        Console.WriteLine();
                        Console.WriteLine("Producto agregado correctamente.");
                        Console.ReadKey();

                        break;


                    case 2:
                        // MOSTRAR PRODUCTOS

                        Console.Clear();
                        Console.WriteLine("=========== PRODUCTOS REGISTRADOS ===========");

                        if (listaProductos.Count == 0)
                        {
                            Console.WriteLine("No hay productos registrados.");
                        }
                        else
                        {
                            foreach (Productos producto in listaProductos)
                            {
                                producto.MostrarInformacion();
                                Console.WriteLine("--------------------------------------------");
                            }
                        }

                        Console.ReadKey();

                        break;


                    case 3:
                        // BUSCAR PRODUCTO

                        Console.Clear();
                        Console.WriteLine("=========== BUSCAR PRODUCTO ===========");

                        Console.Write("Ingrese el código del producto: ");
                        int codigoBuscar = int.Parse(Console.ReadLine());

                        Productos productoEncontrado = null;

                        foreach (Productos producto in listaProductos)
                        {
                            if (producto.ObtenerCodigo() == codigoBuscar)
                            {
                                productoEncontrado = producto;
                                break;
                            }
                        }

                        if (productoEncontrado != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Producto encontrado:");
                            Console.WriteLine("--------------------------------------------");
                            productoEncontrado.MostrarInformacion();
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }

                        Console.ReadKey();

                        break;


                    case 4:
                        // ELIMINAR PRODUCTO

                        Console.Clear();
                        Console.WriteLine("=========== ELIMINAR PRODUCTO ===========");

                        Console.Write("Ingrese el código del producto que desea eliminar: ");
                        int codigoEliminar = int.Parse(Console.ReadLine());

                        Productos productoEliminar = null;

                        foreach (Productos producto in listaProductos)
                        {
                            if (producto.ObtenerCodigo() == codigoEliminar)
                            {
                                productoEliminar = producto;
                                break;
                            }
                        }

                        if (productoEliminar != null)
                        {
                            listaProductos.Remove(productoEliminar);

                            Console.WriteLine();
                            Console.WriteLine("Producto eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Producto no encontrado.");
                        }

                        Console.ReadKey();

                        break;


                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Programa finalizado.");
                        break;


                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);
        }
    }
}
