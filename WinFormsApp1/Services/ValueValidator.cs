using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Implements statistical data validation.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Checks that the number is not bigger than the border.
        /// </summary>
        /// <param name="value">Subject that we check.</param>
        /// <param name="max">Upper border.</param>
        /// <param name="propertyName">Name of the subject.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {maxLength}");
            }
        }


        /// <summary>
        /// Checks if the number is in the gap.
        /// </summary>
        /// <param name="value">Checks the number.</param>
        /// <param name="min">Lower border.</param>
        /// <param name="max">Upper border.</param>
        /// <param name="propertyName">Name of the subject.</param>
        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {minLength} and bigger than {maxLength}");
            }
        }

    }
}


