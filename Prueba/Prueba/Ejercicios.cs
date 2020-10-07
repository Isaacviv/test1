
using Helloworld;

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

        // Ejercicio: hacer un programa que imprima si un numero es primo o no
        public static void Ejercicio3()
        {
            int i = 1;
            while (i <= 100)
            {
                if (Misc.Isprime(i))
                {
                    System.Console.WriteLine(i);
                    i++;
                }
                else
                    i++;
            }
        }
        public static void Ejercicio4()
        {
            for (int i = 0; i < 90; i++)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }
        public static void Ejercicio5()
        {
            long number1 = 0;
            long number2 = 1;
            for(int i = 0; i < 90; i++)
            {
                System.Console.WriteLine(number1 + number2);
                number2 = number2 + number1;
                number1 = number2 - number1;

            }

        }


    }

}
