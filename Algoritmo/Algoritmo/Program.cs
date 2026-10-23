using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // Controla el acceso al contador de lectores.
    static SemaphoreSlim lectores = new SemaphoreSlim(1, 1);

    // Evita que un escritor escriba mientras otros leen o escriben.
    static SemaphoreSlim escritor = new SemaphoreSlim(1, 1);

    // Guarda la cantidad de lectores que están leyendo.
    static int cantidadLectores = 0;

    // Metodo para que un lector pueda leer.
    static void Leer(int id)
    {
        // Protege el contador para evitar cambios al mismo tiempo.
        lock (lectores)
        {
            cantidadLectores++;

            // Si es el primer lector, bloquea al escritor.
            if (cantidadLectores == 1)
                escritor.Wait();
        }

        // Muestra que el lector esta leyendo.
        Console.WriteLine("Lector " + id + " esta leyendo...");

        // Simula el tiempo de lectura.
        Thread.Sleep(1000);

        lock (lectores)
        {
            // El lector termina de leer.
            cantidadLectores--;

            // Si ya no hay lectores, permite escribir.
            if (cantidadLectores == 0)
                escritor.Release();
        }
    }

    // Metodo para que un escritor pueda escribir.
    static void Escribir(int id)
    {
        // Espera hasta tener acceso exclusivo.
        escritor.Wait();

        // Muestra que el escritor esta escribiendo.
        Console.WriteLine("Escritor " + id + " esta escribiendo...");

        // Simula el tiempo que tarda en escribir.
        Thread.Sleep(1500);

        // Libera el recurso para que otros puedan utilizarlo.
        escritor.Release();
    }

    static void Main()
    {
        // Inicia dos lectores al mismo tiempo.
        Task lector1 = Task.Run(() => Leer(1));
        Task lector2 = Task.Run(() => Leer(2));

        // Inicia un escritor.
        Task escritor1 = Task.Run(() => Escribir(1));

        // Espera a que terminen todas las tareas.
        Task.WaitAll(lector1, lector2, escritor1);

        // Indica que el programa termino.
        Console.WriteLine("Proceso terminado.");

        Console.ReadKey();
    }
}
