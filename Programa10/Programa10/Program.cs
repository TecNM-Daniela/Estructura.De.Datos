using System;
class Programa10
{
    static void Main()
    {
        //Lista de enteros
        int[] original = { 1, 2, 3, 4, 5 };
        //Copia de lista
        int[] copia = new int[original.Length];
        //Copia las variablesde la original a la copia
        for (int i = 0; i < original.Length; i++)
            //Asigna el valor de la original a la copia
            copia[i] = original[i];
        //Muestra la lista original
        foreach (int num in copia)
            Console.Write(num + " ");
    }
}