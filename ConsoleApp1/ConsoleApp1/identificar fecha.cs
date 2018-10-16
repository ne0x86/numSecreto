using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un día del mes");
            int dia = int.Parse(Console.ReadLine());
            while (dia == 0)
            {
                Console.WriteLine("El intérvalo es de 1 a 31, prueba otra vez");
                dia = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dime mes");
            String mes = Console.ReadLine();

            if (dia <= 31 && mes == "enero" || mes == "marzo" || mes == "mayo" || mes == "julio" || mes == "agosto" || mes == "octubre" || mes == "diciembre")
            {
                Console.WriteLine("La fecha es correcta");
            }
            else if (dia <= 30 && mes == "abril" || mes == "junio" || mes == "septiembre" || mes == "noviembre")
            {
                Console.WriteLine("La fecha es correcta");
            }
            else if (dia <= 28 && mes == "febrero")
            {
                Console.WriteLine("La fecha es correcta");
            }
            else
            {
                Console.WriteLine("La fecha es incorrecta");
            }
            
            String  [] coches = new String [3];

        }
    }
}
