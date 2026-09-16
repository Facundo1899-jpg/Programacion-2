using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
namespace EjecutarPractico
    {
        internal class Practico1
        {
            public static void EjecutarEjercicios()
            {
                Ejercicio1();
                Ejercicio2();
                Ejercicio3();
                Ejercicio4();
                Ejercicio5();
                Ejercicio6();
                Ejercicio7();
                Ejercicio8();
                Ejercicio9();
                Ejercicio10();
            }
            public static void Ejercicio1()
            {
                try
                {
                    int numero = FuncionesComunes.Leer("Ingrese un numero:");
                    Console.WriteLine("El numero ingresado es: " + numero);
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 1.");
                }
            }

            public static void Ejercicio2()
            {
                try
                {
                    int numero1 = FuncionesComunes.Leer("Ingrese el primer numero");
                    int numero2 = FuncionesComunes.Leer("Ingrese el segundo numero");
                    Console.WriteLine("La suma de los numeros es: " + (numero1+numero2));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 2.");
                }
            }

            public static void Ejercicio3()
            {
                try
                {
                    int num1 = FuncionesComunes.Leer("Ingrese el primer valor");
                    int num2 = FuncionesComunes.Leer("Ingrese el segundo valor");
                    Console.WriteLine("la suma de los numeros es: " + (num1+num2));
                    Console.WriteLine("La resta de los numeros es: " + (num1-num2));
                    Console.WriteLine("La multiplicacion de los numeros es: " + (num1*num2));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 3");
                }
            }

            public static void Ejercicio4()
            {
                try
                {
                    int largo = FuncionesComunes.Leer("Ingrese largo.");
                    int ancho = FuncionesComunes.Leer("Ingrese ancho.");
                    Console.WriteLine("El area es de: " + (largo*ancho));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 4");
                }
            }

            public static void Ejercicio5()
            {
                try
                {
                    int largo1 = FuncionesComunes.Leer("Ingrese largo.");
                    int ancho1 = FuncionesComunes.Leer("Ingrese ancho.");
                    Console.WriteLine("El perimetro es: " + ((largo1+ancho1) * 2));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 5");
                }
            }

            public static void Ejercicio6()
            {
                try
                {
                    int grados = FuncionesComunes.Leer("Ingrese los grados.");
                    Console.WriteLine("Los grados pasados a Fahrenheit son: " + ((grados*9/5)+32));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 6.");
                }
            }

            public static void Ejercicio7()
            {
                try
                {
                    int km = FuncionesComunes.Leer("Ingrese los kilometros.");
                    Console.WriteLine("Los kilometros pasados a metros son: " + (km*1000));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 7.");
                }
            }

            public static void Ejercicio8()
            {
                try
                {
                    int num1 = FuncionesComunes.Leer("Ingrese el primer numero.");
                    int num2 = FuncionesComunes.Leer("Ingrese el segundo numero.");
                    int num3 = FuncionesComunes.Leer("Ingrese el tercer numero.");
                    Console.WriteLine("El promedio de los numeros es de: " + ((num1+num2+num3)/3));
                }
                catch(Exception)
                {
                    Console.WriteLine("No se pudo llevar a cabo el Ejercicio 8.");
                }
            }

            public static void Ejercicio9()
            {
                try
                {
                    int num = FuncionesComunes.Leer("Ingrese el numero.");
                    Console.WriteLine("El doble es: " + (num * 2));
                    Console.WriteLine("El triple es: " + (num * 3));
                }
                catch(Exception)
                {
                 Console.WriteLine("No se pudo llevar a cabo el Ejercicio 9.");   
                }           
            }

            public static void Ejercicio10()
            {
                try
                {
                    int precio = FuncionesComunes.Leer("Ingrese el precio.");
                    Console.WriteLine("El precio final es: " + precio*1,22);
                }
                catch(Exception)
                {
                Console.WriteLine("No se pudo llevar a cabo el Ejercio 9.");
                }
            }
        }
    }
