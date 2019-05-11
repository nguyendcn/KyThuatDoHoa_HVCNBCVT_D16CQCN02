using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct.DefineType
{
    public static class Matrixs
    {
        /// <summary>
        /// Multiply two matrixs.
        /// </summary>
        /// <param name="matrix_A">Matrix first.</param>
        /// <param name="matrix_B">Matrix second.</param>
        /// <returns>Result of the multiply two matrices.</returns>
        public static int[][] Multiply(float[][] matrix_A, int[][] matrix_B)
        {
            //Matrix multiplication not possible
            if (matrix_A[0].Length != matrix_B.Length)
            {
                throw new Exception("Matrix multiplication not possible!");
            }

            int rows = matrix_A.Length,
                cols = matrix_B[0].Length;

            int[][] result = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                result[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    result[row][col] = 0;
                    for (int k = 0; k < rows; k++)
                    {
                        result[row][col] += (int)(matrix_A[row][k] * matrix_B[k][col]);
                    }
                }
            }
            return result;
        }
    }
}
