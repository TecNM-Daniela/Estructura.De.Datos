using System;
class Programa8
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { -3, 5, -1, 8, -2 };
        // Contador de negativos
        int contador = 0;
        // Recorre la lista cuenta los negativos
        foreach (int num in numeros)
            // Si es negativo invrementa el contador
            if (num < 0)
                //Suma al contador
                contador++;
        Console.WriteLine("Cantidad de negativos: " + contador);
    }
}