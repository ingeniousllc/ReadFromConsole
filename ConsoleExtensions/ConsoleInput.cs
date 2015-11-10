using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtensions
{
    public static class ConsoleInput
    {
        /// <summary>
        /// Tries to read the specified type from the Console.
        /// </summary>
        /// <typeparam name="T">Type of the value to read.</typeparam>
        /// <param name="value">The value to read.</param>
        /// <returns><c>true</c> if the value was read from the Console, <c>false</c> otherwise.</returns>
        public static bool TryRead<T>(out T value)
        {
            var line = Console.ReadLine();
            value = default(T);
            bool conversionSucceeded = false;

            try
            {
                value = (T)Convert.ChangeType(line, typeof(T));
                conversionSucceeded = true;
            }
            catch
            {
                conversionSucceeded = false;
            }

            return conversionSucceeded;
        }
    }
}
