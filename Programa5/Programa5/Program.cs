using System;
class Programa5
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { 1, 2, 3, 4, 5, 6 };
        //Bucle que empieza en la ultima posicion
        //y va retrocediendo
        for (int i = numeros.Length - 1; i >= 0; i--)
            Console.WriteLine(numeros[i] + " ");
    }
}