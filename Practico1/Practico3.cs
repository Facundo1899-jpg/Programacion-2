using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
namespace EjecutarPractico
{
    internal class Practico3
    { 
         public static void EjecutarEjercicios()
            {
                Ejercicio21();
                Ejercicio22();
                Ejercicio23();
                Ejercicio24();
                Ejercicio25();
                Ejercicio26();
                Ejercicio27();
                Ejercicio28();
                Ejercicio29();
                Ejercicio30();
            }
        public static void Ejercicio21()
        {
            int num = FuncionesComunes.Leer("Ingrese un numero.");
                if (num > 0)
                {
                    Console.WriteLine("El numero " + num + " ingresado es positivo.");
                }
                if(num<0)
                {
                    Console.WriteLine("El numero " + num + " ingresado es negativo.");
                }
                else if(num == 0)
                {
                    Console.WriteLine("El numero ingresado es cero.");
                }    
        }

        public static void Ejercicio22()
        {
            int numero = FuncionesComunes.Leer("Ingrese un numero.");
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es impar.");
            }
        }

        public static void Ejercicio23()
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

        public static void Ejercicio24()
        {
            int numero1 = FuncionesComunes.Leer("Ingrese el primer numero.");
            int numero2 = FuncionesComunes.Leer("Ingrese el segundo numero.");
            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es " + numero1);
            }
            else if(numero2>numero1)
            {
                Console.WriteLine("El numero mayor es " + numero2);
            }
            else
            {
                Console.WriteLine("Los numeros son iguales.");
            }
              
        }

        public static void Ejercicio25()
        {
            double precio = FuncionesComunes.Leer("Ingrese precio");
            double descuento = 0;
            if (precio >= 1000)
            {
                descuento = precio * 0.20;
                precio = precio - descuento;
                Console.WriteLine("La compra tiene un 20% de descuento el precio final es de: " + precio);
            }
            else
            {
                Console.WriteLine("La compra no tiene descuento.");
            }
        }
            
        public static void Ejercicio26()
        {
            int temperatura = FuncionesComunes.Leer("Ingrese la temperatura.");
            if (temperatura >= 30)
            {
                Console.WriteLine("Hoy hace calor.");
            }
            else if(temperatura>20 && temperatura < 30)
            {
                Console.WriteLine("Hoy esta templado.");
            }
            else
            {
                Console.WriteLine("Hoy hace frio.");
            }
        }

        public static void Ejercicio27()
        {
            int numero = FuncionesComunes.Leer("Ingrese un numero");
            if (numero % 3 == 0)
            {
                Console.WriteLine("El numero es divisible por 3.");
            }
            else
            {
                Console.WriteLine("El numero no es divisible por 3.");
            }
        }

        public static void Ejercicio28()
        {
            int numero1 = FuncionesComunes.Leer("Ingrese el primer numero.");
            int numero2 = FuncionesComunes.Leer("Ingrese el segundo numero.");
            if(numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales.");
            }
            else
            {
                Console.WriteLine("Los numeros son distintos.");
            }
        }

        public static void Ejercicio29()
        {
            int año= FuncionesComunes.Leer("Ingrese el año.");
            if(año % 4 == 0)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }  
        }

        public static void Ejercicio30()
        {
            string contraseña = FuncionesComunes.LeerTexto("Ingrese una contraseña. (Minimo 8 caracteres.)");
            if (contraseña.Length > 8)
            {
                Console.WriteLine("Contrsaeña validada con exito.");
            }
            else
            {
                Console.WriteLine("Contraseña invalida: Debe tener minimo 8 caracteres.");
            }
        }
    }
}