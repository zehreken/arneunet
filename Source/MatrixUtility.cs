namespace arneunet.Source
{
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