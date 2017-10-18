using System;
using System.Collections.Generic;
using arneunet.Source;

namespace arneunet
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int rowCount = 10;
			int columnCount = 10;
			var matrix = new float[rowCount, columnCount];
			matrix[1, 0] = 1;
			
			Console.WriteLine(matrix.ToPrintable());
		}
	}
}