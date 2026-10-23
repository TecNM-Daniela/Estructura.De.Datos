using System;
class Programa2
{
    static void Main()
    {
        //Lista fija de numeros desordenados
        int[] numeros = { 4, 9, 2, 7, 5 };
        //Se cree que el primer numero es el mayor
        int mayor = numeros[0];
        //Recorre cada numero
        foreach (int num in numeros)
            //Compara si es mayor que el actual
            if (num > mayor)
                // ACtualiza la variable con el nuevo
                mayor = num;
        Console.WriteLine("El número mayor es:  " + mayor);

    }
}