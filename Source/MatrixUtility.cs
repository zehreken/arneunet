using System;
using System.Runtime.CompilerServices;

namespace arneunet.Source
{
	// In a matrix
	// First index represents row
	// Second index represents column
	public static class MatrixUtility
	{
		public static T[,] Transpose<T>(T[,] matrix)
		{
			var row = matrix.GetLength(0);
			var column = matrix.GetLength(1);
			var transposed = new T[column, row];
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					transposed[j, i] = matrix[i, j];
				}
			}

			return transposed;
		}

		public static float[,] Sum(float[,] a, float[,] b)
		{
			var rowA = a.GetLength(0);
			var columnA = a.GetLength(1);
			var rowB = b.GetLength(0);
			var columnB = b.GetLength(1);
			if (rowA != rowB || columnA != columnB)
			{
				throw new Exception("Matrix dimensions don't match!");
			}

			var sum = new float[rowA, columnA];
			for (int i = 0; i < rowA; i++)
			{
				for (int j = 0; j < columnA; j++)
				{
					sum[i, j] = a[i, j] + b[i, j];
				}
			}

			return sum;
		}

		public static string ToPrintable<T>(this T[,] matrix)
		{
			var s = "printable\n";
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					s += matrix[i, j] + ", ";
				}
				s += "\n";
			}

			return s;
		}
	}
}