using Helloworld;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Ejercicios
    {
        // EJERCICIO: Hacer una funcion que inprima por
        // pantalla los numeros del 0 al 99
        public static void Ejercicio1()
        {
            int contador = 0;
            while(contador < 100)
            {
                System.Console.WriteLine(contador);
                // Contador = contador + 1
                // Contador += 1
                contador++;
            }
        }

        // Ejercicio: Hacer una funcion que imprima todos los numerospares desde 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                {
                    System.Console.WriteLine(i);
                    i++;
                }
                else
                    i++;
            }
        }
    }
}
