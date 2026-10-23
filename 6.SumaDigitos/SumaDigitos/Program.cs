using System;
class Program
{
    static int SumarDigitos(int n)
    {
        if(n == 0)
            return 0;
              return n % 10 + SumarDigitos(n / 10);
        
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        if(n<0)
        {
            Console.WriteLine("Ingrese un número positivo");
            return;
        }
        Console.WriteLine("La suma de los dígitos: " + SumarDigitos(n));
    }
}