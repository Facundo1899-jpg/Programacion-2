using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
    namespace EjecutarPractico
    {
        internal class FuncionesComunes
        {
            public static int Leer(string message)
            {
                Console.WriteLine(message);
                string valor1= Console.ReadLine();
                    if (!Int32.TryParse(valor1, out int numeroIngresado))
                        throw new Exception("El valor ingresado no es un numero valido.");
                        
                        return numeroIngresado; 
            }
            public static string LeerTexto(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }
        
    
public static void EjecutarPractico(int practico)
{
    switch(practico)
    {
        case 1:
            Practico1.EjecutarEjercicios();
            break;
        case 2:
            Practico2.EjecutarEjercicios();
            break;
        case 3:
            Practico3.EjecutarEjercicios();
            break;
        case 4: 
            Practico4.EjecutarEjercicios();
            break;
        default:
        Console.WriteLine("No existe ese practico.");
        break;

    }
}
    }
}