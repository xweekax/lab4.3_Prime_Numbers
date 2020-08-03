using System;
using System.Collections.Generic;
using System.Text;

namespace lab4._3_Prime_Numbers
{
    public class PrimeNumbers
    {
        public static bool getPrime(int number2)
        {
            int counter = 0;
            for (int index = 2; index < number2; index++)
            {
                if (number2 % index == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}

