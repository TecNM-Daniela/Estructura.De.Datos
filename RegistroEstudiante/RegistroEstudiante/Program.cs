using System;

namespace RegistroEstudiante
{
    class Estudiante
    {
        // Atributos
        private string matricula;
        private string nombre;
        private int edad;
        private string carrera;
        private int semestre;

        // Método para registrar estudiante
        public void RegistrarEstudiante(string matricula, string nombre, int edad, string carrera, int semestre)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
            this.semestre = semestre;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("====== Datos del estudiante ============");
            Console.WriteLine("========================================");
            Console.WriteLine("   Matrícula: " + matricula);
            Console.WriteLine("   Nombre:    " + nombre);
            Console.WriteLine("   Edad:      " + edad);
            Console.WriteLine("   Carrera:   " + carrera);
            Console.WriteLine("   Semestre:  " + semestre);
            Console.WriteLine("   Tipo edad: " + ObtenerTipoEdad());
            Console.WriteLine("========================================");
        }

        // Método para obtener el tipo de edad
        public string ObtenerTipoEdad()
        {
            if (edad >= 18)
            {
                return "Mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
        }
    }

    class Program
    {
        // Método para solicitar la matrícula
        static string PedirMatricula()
        {
            Console.WriteLine("Ingresa la matrícula:");
            return Console.ReadLine();
        }

        // Método para solicitar el nombre
        static string PedirNombre()
        {
            Console.WriteLine("Ingresa el nombre:");
            return Console.ReadLine();
        }

        // Método para solicitar la edad
        static int PedirEdad()
        {
            int edad;

            Console.WriteLine("Ingresa la edad:");

            while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
            {
                Console.WriteLine("Edad no válida. Ingrese nuevamente:");
            }

            return edad;
        }

        // Método para solicitar la carrera
        static string PedirCarrera()
        {
            Console.WriteLine("Ingresa la carrera:");
            return Console.ReadLine();
        }

        // Método para solicitar el semestre
        static int PedirSemestre()
        {
            int semestre;

            Console.WriteLine("Ingresa el semestre:");

            while (!int.TryParse(Console.ReadLine(), out semestre) || semestre <= 0)
            {
                Console.WriteLine("Semestre no válido. Ingrese nuevamente:");
            }

            return semestre;
        }

        // Método para mostrar el encabezado
        static void MostrarEncabezado()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("====== Registro del estudiante =========");
            Console.WriteLine("========================================");
        }

        // Programa principal
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            MostrarEncabezado();

            // Solicitar datos mediante métodos
            string matricula = PedirMatricula();
            string nombre = PedirNombre();
            int edad = PedirEdad();
            string carrera = PedirCarrera();
            int semestre = PedirSemestre();

            // Registrar estudiante
            estudiante.RegistrarEstudiante(
                matricula,
                nombre,
                edad,
                carrera,
                semestre
            );

            // Mostrar información
            estudiante.MostrarDatos();

            Console.WriteLine("\nPresione ENTER para finalizar");
            Console.ReadLine();
        }
    }
}