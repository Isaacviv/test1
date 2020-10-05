using System;
using System.Collections.Generic;
using System.Text;

namespace Helloworld
{
    class Maths
    {
        public static EquationSolution2 SolveEquation2(double a, double b, double c)
        {
            double aux1, aux2;
            EquationSolution2 result;

            result = new EquationSolution2();

            aux1 = b * b - 4 * a * c;
            aux2 = System.Math.Sqrt(aux1);
            
            result.solution1 = (-b + aux2) / (2.0 * a);
            result.solution2 = (-b - aux2) / (2.0 * a);
            return result;
        }
        public static double SolveEquation1(double a, double b)
        {
            double x;
            x = -b / a;
            return x;
        }
    }
}
