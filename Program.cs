// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {

                // Cambiar color de fondo y texto
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Clear(); // Importante para aplicar el color de fondo en toda la pantalla
        
        Console.WriteLine("Hola Mundo!");
        Console.WriteLine("Hello world");
        

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}
