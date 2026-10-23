using System;
class Programa1
{
    static void Main()
    {
        //Creacion de un arreglo
        int[] numeros = { 1, 2, 3, 4, 5 };
        //Variable para guardar la suma
        int suma = 0;
        //Bucle que recorre cada posicion de inicio a fin
        for (int i = 0; i < numeros.Length; i++)
            //Suma el valor de la posicion actual
            suma += numeros[i];
        Console.WriteLine("La suma es: " + suma);
    }
}