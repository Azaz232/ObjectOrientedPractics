using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Implements statistical generation of the next number for an object.
    /// </summary>
    internal class IdGenerator
    {
        /// <summary>
        /// Counter for all existing object.
        /// </summary>
        private static int _nextId;

        /// <summary>
        /// Generates next number.
        /// </summary>
        /// <returns>Returns next number for an object.</returns>
        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}
