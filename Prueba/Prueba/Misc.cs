
using System.Data;

namespace Helloworld
{
    class Misc
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // This function returns true if the number
        // is even (par) and false otherwise
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }
        public static bool Ispositive(int value)
        {
            if (value >= 0)
                return true;
            else
                return false;
        }
        public static bool Isprime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
     
    }
}
