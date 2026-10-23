using System;
class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        else
            return Invertir(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un número positivo: ");
        long n = long.Parse(Console.ReadLine());
        if(n<0)
        {
            Console.WriteLine("El número debe ser positivo.");
            return;
        }
        
        Console.WriteLine("El número invertido es: " + Invertir(n));
    }
}