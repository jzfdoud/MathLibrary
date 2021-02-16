using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    class Math
    {
        public static int Addition(int nbr1, int nbr2)
        {
            return nbr1 + nbr2;
        }

        public static int Subtraction(int nbr1, int nbr2)
        {
            return nbr1 - nbr2;
        }

        public static int Multiplication(int nbr1, int nbr2)
        {
            return nbr1 * nbr2;
        }

        public static int Division(int nbr1, int nbr2)
        {
            return nbr1 / nbr2;
        }

        public static int Modulo(int nbr1, int nbr2)
        {
            return nbr1 - (nbr1 / nbr2 * nbr2);
        }

        public static int Power(int nbr1, int nbr2)
        {
            var answer = 1;
            for( var idx = 0; idx < nbr2; idx++)
            {
                answer *= nbr1;
            }
            return answer;
        }

        public static bool isEven(int i)
        {
            if((Modulo(i,2)) == 0)
            {
                return true;
            }
            else
            { return false; }
        }

        public static int Inc(int i)
        {
            return i + 1;
        }

        public static int Dec(int i)
        {
            return i - 1;
        }
    }
}
