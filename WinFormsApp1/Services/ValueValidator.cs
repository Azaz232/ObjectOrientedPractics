using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedPractics.Services
{
    class ValueValidator
    {

        public static void AssertStringOnLength(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} is expected to be a positive number");
            }
        }

        public static void AssertStringOnLength(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} is expected to be a positive number");
            }
        }



        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {maxLength}");
            }
        }



        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {minLength} and bigger than {maxLength}");
            }
        }

    }
}


