using System;

namespace ConsoleApp10
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al juego del número secreto");
            Console.ReadKey();
            Console.WriteLine("Tienes que adivinar el número que estoy pensando entre 1 y 20...");
            Random generador = new Random();
            int numSecreto = generador.Next(21);
            int intentos = 0;
            while (intentos == 0)
            {
                Console.WriteLine("Primero elige la dificultad: 1 = fácil, 2 = mediana, 3 = difícil");
                int diff = int.Parse(Console.ReadLine());
                if (diff == 1)
                {
                    intentos = 10;
                }
                else if (diff == 2)
                {
                    intentos = 5;
                }
                else if (diff == 3)
                {
                    intentos = 3;
                }
                else
                {
                    Console.WriteLine("Dificultad no válida, introduce otro valor");
                }
            }
            Console.WriteLine("Dime que número crees que es");
            int prueba = int.Parse(Console.ReadLine());
            if (prueba == numSecreto)
            {
                Console.WriteLine("Has acertado!!");
                Console.WriteLine("Fin del juego!");
            }
            else
                intentos--;
            {
                while (intentos > 0 && prueba != numSecreto)
                {
                    intentos--;
                    Console.WriteLine("Has fallado! Prueba otra vez");
                    prueba = int.Parse(Console.ReadLine());
                    if (prueba == numSecreto)
                    {
                        Console.WriteLine("Has acertado!!");
                        Console.WriteLine("Fin del juego!");
                    }
                    if (intentos == 0)
                    {
                        Console.WriteLine("Te has quedado sin intentos");
                        Console.WriteLine("Fin del juego");
                    }
                }
            }
        }
    }
}