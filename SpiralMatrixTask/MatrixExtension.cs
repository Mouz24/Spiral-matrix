using System;

#pragma warning disable CA1814
#pragma warning disable S2368

namespace SpiralMatrixTask
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"{size}");
            }

            int k = 1;
            int r1 = 0, r2 = size - 1;
            int[,] arr = new int[size, size];
            
            while (k <= size * size)
            {
                for (int i = r1; i <= r2; i++)
                {
                    arr[r1, i] = k++;
                }

                for (int j = r1 + 1; j <= r2; j++)
                {
                    arr[j, r2] = k++;
                }

                for (int j = r2 - 1; j >= r1; j--)
                {
                    arr[r2, j] = k++;
                }

                for (int i = r2 - 1; i >= r1 + 1; i--)
                {
                    arr[i, r1] = k++;
                }

                r1++;
                r2--;
            }

            return arr;
        }
    }
}
