using System;
class Programa3
{
    static void Main()
    //Lista de numeros
    { int[] numeros = { 10, 20, 30, 40, 50 };
        //Variables para acumular
        int suma = 0;
        //Recorre todos los nuemros
        foreach (int num in numeros) 
        {
            //Acumula cada varol en la variable
            suma += num;
        }
        //Convierte suma a decimal 
        double promedio = (double)suma / numeros.Length;

        Console.WriteLine("El promedio es: " + promedio);
            
    }
}

