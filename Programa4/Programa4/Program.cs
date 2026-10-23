using System;
class Program
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Se guarda la cantidad de numeros pares
        int contador = 0;
        //Recorre cada numero
        foreach (int num in numeros)
            //Se sabe si el numero es divisible entre 
            if (num % 2 == 0)
                //Incrementa el contador
                contador++;
        Console.WriteLine("Cantidad de pares: " + contador);

    }
}
