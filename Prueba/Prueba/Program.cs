using Helloworld;
using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            Ejercicios.Ejercicio1();
            Ejercicios.Ejercicio2(100);
            Ejercicios.Ejercicio3();
            Ejercicios.Ejercicio4();
            Ejercicios.Ejercicio5();

            Student s1, s2;
            s1 = new Student();
            s2 = new Student();
            s1.name = "Abel";
            s2.name = "Alex";

            string ss = s1.getNameTwice();
        }
    }
}
