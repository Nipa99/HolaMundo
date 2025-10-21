// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {

        string hola = "Hola Mundo en Arcoiris!\n";
        string hello = "Hello world as a rainbow!";
        ConsoleColor[] colores = new ConsoleColor[]
        {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Magenta
        };

        for (int i = 0; i < hola.Length; i++)
        {
            Console.ForegroundColor = colores[i % colores.Length];
            Console.Write(hola[i]);
        }


        ConsoleColor[] colors = new ConsoleColor[]
        {
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Magenta,
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green
        };

        for (int i = 0; i < hello.Length; i++)
        {
            Console.ForegroundColor = colors[i % colors.Length];
            Console.Write(hello[i]);
        }

        Console.WriteLine("Adios a todos!!");

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}
