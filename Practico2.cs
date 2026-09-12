using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
namespace EjecutarPractico
{
    internal class Practico2
    {
         public static void EjecutarEjercicios()
            {
                Ejercicio11();
                Ejercicio12();
                Ejercicio13();
                Ejercicio14();
                Ejercicio15();
                Ejercicio16();
                Ejercicio17();
                Ejercicio18();
                Ejercicio19();
                Ejercicio20();
            }
        public static void Ejercicio11()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
            if (num > 0)
            {
                Console.WriteLine("El numero ingresado es positivo.");
            }
            else
            {
                Console.WriteLine("El numero ingresado es negativo.");
            }    
        }
        public static void Ejercicio12()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
            if (num < 0)
            {
                Console.WriteLine("El numero ingresado es negativo.");
            }
            else
            {
                Console.WriteLine("El numero ingresado es positivo.");
            }
        }

        public static void Ejercicio13()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
            if (num % 2 == 0)
            {
                 Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero es impar.");
            }
        }

        public static void Ejercicio14()
        {
            int edad= FuncionesComunes.Leer("Ingrese la edad de la persona.");
            if(edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad.");
            }
        }
        public static void Ejercicio15()
        {
            int num1 = FuncionesComunes.Leer("Ingrese el primer numero");
            int num2 = FuncionesComunes.Leer("Ingrese el segundo numero.");
            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else if(num2>num1)
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
            else
            {
                Console.WriteLine("Los numeros ingresados son iguales.");
            }   
        }

        public static void Ejercicio16()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
            if (num % 5 == 0)
            {
                 Console.WriteLine("EL numero " + num + " es multiplo de 5.");
            }
            else
            {
                Console.WriteLine("El numero " + num + " no es multiplo de 5.");
            }
        }

        public static void Ejercicio17()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
            if (num > 100)
            {
                Console.WriteLine("El numero ingresado es mayor a 100.");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es mayor a 100.");
            }
        }

        public static void Ejercicio18()
        {
            int nota = FuncionesComunes.Leer("Ingrese una nota.");
            if (nota >= 6)
            {
                Console.WriteLine("Usted aprobo.");
            }
            else
            {
                Console.WriteLine("Usted reprobo.");
            }
        }

        public static void Ejercicio19()
        {
            int numero = FuncionesComunes.Leer("Ingrese un numero.");
            if(numero>10 && numero < 20)
            {
                Console.WriteLine("El numero " + numero + " esta entre el 10 y el 20.");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no esta entre el 10 y el 20.");
            }
        }

        public static void Ejercicio20()
        {
            string letra = FuncionesComunes.LeerTexto("Ingrese una letra.");
            if(letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("La letra " + letra + " es vocal.");
            }
            else
            {
                Console.WriteLine("La letra " + letra + " no es vocal.");
            }
        }
    }
}