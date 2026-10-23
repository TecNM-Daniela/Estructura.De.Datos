using System;
class Program
{
    static bool EsPar(int n)
    {
        if (n == 0)
            return true;
        return Impar(n - 1);

    }
    static bool Impar(int n)
    {
        if (n == 0)
            return false;
        return EsPar(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingrese un número válido entre 0 y 10000.");
            return;
        }
        if (EsPar(n))
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}