using System;
using System.Collections.Generic;
using arneunet.Source;

namespace arneunet
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int row = 2;
			int column = 3;
			var matrix = new float[row, column];

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					matrix[i, j] = i + ((i + 1) * j);
				}
			}
			
			var matrix_ = MatrixUtility.Transpose(matrix);
			
			Console.WriteLine(matrix.ToPrintable());
			Console.WriteLine(matrix_.ToPrintable());
		}
	}
}