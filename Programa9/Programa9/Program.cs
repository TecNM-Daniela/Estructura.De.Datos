using System;
class Programa9
{
    static void Main()
    {
        //Lista de numeros
        int[] numeros = { 1, 2, 3, 4 };
        // Calcula el producto de los numeros
        int producto = 1;
        //Recorre la lista y multiplica por el producto
        foreach (int num in numeros)
            //Multiplica producto por el actual
            producto *= num;
        Console.WriteLine("Producto total: " + producto);
    }
}