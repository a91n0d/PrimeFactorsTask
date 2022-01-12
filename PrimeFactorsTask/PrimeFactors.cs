using System;

namespace PrimeFactorsTask
{
    public static class PrimeFactors
    {
        /// <summary>
        /// Compute the prime factors of a given natural number.
        /// A prime number is only evenly divisible by itself and 1.
        /// Note that 1 is not a prime number.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Prime factors of a given natural number.</returns>
        /// <exception cref="ArgumentException">Thrown when number less or equal 0.</exception>
        /// <example>
        /// 60 => {2, 2, 3, 5}
        /// 8 => {2, 2, 2}
        /// 12 => {2, 2, 3}
        /// 901255 => {5, 17, 23, 461}
        /// 93819012551 => {11, 9539, 894119}.
        /// </example>
        public static int[] GetFactors(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException(null, nameof(number));
            }

            int[] getFactors = Array.Empty<int>();
            while (number > 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0 && i.IsPrime())
                    {
                        Array.Resize(ref getFactors, getFactors.Length + 1);
                        getFactors[^1] = i;
                        number /= i;
                        break;
                    }
                }
            }

            return getFactors;
        }

        /// <summary>
        /// Calculates whether a number is prime or not.
        /// </summary>
        /// <param name="i">Source number.</param>
        /// <returns>The number is prime or not.</returns>
        public static bool IsPrime(this int i)
        {
            bool isPrime = true;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
