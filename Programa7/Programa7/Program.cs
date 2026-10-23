using System;
class Programa7
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { 5, 3, 8, 4, 2 };
        //Ordena los numeros de menor a mayor
        //Controla el numero de pasadas necesarias
        for(int i = 0; i < numeros.Length -1;i++)
        {
            //Compara los elementos de los lados
            for(int j = 0;j< numeros.Length -1 -i;j++)
            {
                //Si el de la izq, es mayor que el de la derecha
                if (numeros[j] > numeros[j+1])
                {
                    //Intercambia los numeros de posicion
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
        //Recorre el arreglo
        foreach (int num in numeros)
            Console.WriteLine(num + " ");
    }
}