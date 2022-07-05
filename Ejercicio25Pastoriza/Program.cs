using System;

namespace Ejercicio25Pastoriza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Analizar letra como vocal o consonantes";
            Console.WriteLine("Ingrese la letra que desea analizar");
            char letra = char.Parse(Console.ReadLine());

        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
           {
                Console.WriteLine("La letra ingresada es una vocal");
            }
        else 
        Console.WriteLine ("NO es una vocal");
    }
    }
}
