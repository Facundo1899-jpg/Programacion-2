using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace EjecutarPractico
{
    internal class Practico4
    {
          public static void EjecutarEjercicios()
            {
                Ejercicio31();
                Ejercicio32();
                Ejercicio33();
                Ejercicio34();
                Ejercicio35();
                Ejercicio36();
                Ejercicio37();
                Ejercicio38();
                Ejercicio39();
                Ejercicio40();
                Ejercicio41();
                Ejercicio42();
                Ejercicio43();
                Ejercicio44();
                Ejercicio45();
            }
        public static void Ejercicio31()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        public static void Ejercicio32()
        {
            for(int i= 1; i<=100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ejercicio33()
        {
            Console.WriteLine("Los numeros pares del 1 al 50 son los siguientes: ");
            for(int i=1; i<=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine( i + " ");
                }
            }
        }

        public static void Ejercicio34()
        {
            Console.WriteLine("Los numeros impares del 1 al 50 son los siguintes: ");
            for(int i=1; i<=50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine( i + " ");
                }
            }
        }

        public static void Ejercicio35()
        {
            int suma=0;
            for(int i=1; i<=10; i++)
            {
                suma+=i;
            }
            Console.WriteLine("La suma es: " + suma);
        }

        public static void Ejercicio36()
        {
            int suma=0;
            for(int i=1; i<=100; i++)
            {
                suma+=i;
            }
            Console.WriteLine("La suma es: " + suma);
        }

        public static void Ejercicio37()
        {
            int numero =FuncionesComunes.Leer("Ingrese un numero.");
            Console.WriteLine("La tabla de multiplicar de " + numero + " es la siguiente: ");
            for(int i= 0; i<=10; i++)
            {
                Console.WriteLine( numero + " x " + i + " = " + (numero*i));
            }
        }

        public static void Ejercicio38()
        {
             
            for(int i=10; i>=1; i--)
            {
                Console.WriteLine(i + " ");
            }
        }

        public static void Ejercicio39()
        {
            int numero =FuncionesComunes.Leer("Ingrese un número:");
            int fact =1;
            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El factorial es: " + fact);
        }

        public static void Ejercicio40()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i + " al cuadrado es: " + (i*i));
            }
        }

        public static void Ejercicio41()
        {
            int num =FuncionesComunes.Leer("Ingrese numeros.(0 para salir.)");
            while (num != 0)
            {
                num=FuncionesComunes.Leer("Ingrese numeros. (0 para salir.)");
            }
            Console.WriteLine("Los numeros ingresados son: " + num);
        }
        public static void Ejercicio42()
        {
            int num =FuncionesComunes.Leer("Ingrese numeros. (cero para salir.)");
            int contPositivos=0;
            while (num != 0)
            {
                num =FuncionesComunes.Leer("Ingrese numeros. (cero para salir.)");
                if (num > 0)
                {
                    contPositivos++;
                }
            }
             Console.WriteLine("Hay " + contPositivos + " numeros positivos.");
        }

        public static void Ejercicio43()
        {
            int suma =0;
            int cant =FuncionesComunes.Leer("¿Cuantos numeros ingresara?");
            for(int i=0; i<cant; i++)
            {
                int num =FuncionesComunes.Leer("Ingrese un numero");
                suma += num;
            }
            int promedio= suma/cant;
            Console.WriteLine("El promedio de la cantidad de numeros ingresados es: " + promedio);
        }

        public static void Ejercicio44()
        {
            Console.WriteLine("Los multiplos de 3 hasta el 100 son: ");
            for(int i=0; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Ejercicio45()
        {
            int a=0;
            int b=1;
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(a);
                int c=a+b; 
                a=b;
                b=c;
            }
        }
    }

}