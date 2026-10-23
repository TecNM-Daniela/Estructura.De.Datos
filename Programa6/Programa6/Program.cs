using System;
class Programa6
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { 5, 8, 12, 20 };
        //Numero a buscar
        int buscado = 8;
        //Variable para saber si existe o no
        bool encontrado = false;
        //Recorre cada elemento
        foreach (int num in numeros)
            //Comprueba si es el numero buscado
            if (num == buscado)
                //Si es asi, cambia a verdadero
                encontrado = true;
        Console.WriteLine("¿Fue encontrado? " + encontrado);
    }

}