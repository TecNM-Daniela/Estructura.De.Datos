using System;

namespace RegistroEmpleado
{
    class Empleado
    {
        // Atributos
        private string nombre;
        private string numeroEmpleado;
        private string puesto;
        private double salarioMensual;

        // Registrar datos empleado
        public void RegistrarEmpleado(string nombre, string numeroEmpleado, string puesto, double salarioMensual)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.puesto = puesto;
            this.salarioMensual = salarioMensual;
        }

        // Calcular salario anual
        public double CalcularSalarioAnual()
        {
            return salarioMensual * 12;
        }

        // Determinar nivel salarial
        public string DeterminarNivelSalarial()
        {
            if (salarioMensual < 8000)
            {
                return "Bajo";
            }
            else if (salarioMensual < 15000)
            {
                return "Medio";
            }
            else
            {
                return "Alto";
            }
        }

        // Mostrar datos del empleado
        public void MostrarEmpleado()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Número de empleado: " + numeroEmpleado);
            Console.WriteLine("Puesto: " + puesto);
            Console.WriteLine("Salario mensual: $" + salarioMensual.ToString("F2"));
            Console.WriteLine("Salario anual: $" + CalcularSalarioAnual().ToString("F2"));
            Console.WriteLine("Nivel salarial: " + DeterminarNivelSalarial());
        }
    }

    class Program
    {
        static void Main()
        {
            // Crear objeto empleado
            Empleado empleado = new Empleado();

            // Pedir datos
            Console.WriteLine("REGISTRO DE EMPLEADO");
            Console.WriteLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Número de empleado: ");
            string numeroEmpleado = Console.ReadLine();

            Console.Write("Puesto: ");
            string puesto = Console.ReadLine();

            Console.Write("Salario mensual: $");
            double salarioMensual = Convert.ToDouble(Console.ReadLine());

            // Registrar empleado
            empleado.RegistrarEmpleado(nombre, numeroEmpleado, puesto, salarioMensual);

            Console.WriteLine();
            Console.WriteLine("DATOS DEL EMPLEADO");
            Console.WriteLine("--------------------------");

            // Mostrar información
            empleado.MostrarEmpleado();

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}