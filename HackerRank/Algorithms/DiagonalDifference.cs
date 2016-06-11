using System;
namespace HackerRank
{
	public class DiagonalDifference
	{
		public static void Run()
		{
			// create grid
			string line;
			int gridSize = Convert.ToInt32(Console.ReadLine());
			int[][] grid = new int[gridSize][];

			for (var x = 0; x < gridSize; x++)
			{
				line = Console.ReadLine();
				grid[x] = Array.ConvertAll(line.Split(' '), Int32.Parse);
			}

			// calculate grid diagonals
			int primary = 0;
			int secondary = 0;

			// calculate primary diagonal sum (top left to bottom right)
			for (int offset = 0; offset < gridSize; offset++)
			{
				// Console.WriteLine("x " + offset + ", y " + offset + " value: "+ grid[offset][offset]);
				primary += grid[offset][offset];
			}

			// calculate secondary diagonal sum (top right to bottom left)
			for (int row = 0, col = gridSize - 1; col  >= 0; row++, col--)
			{
				/*
				 * col = 2, row = 0
				 * col = 1, row = 1
				 * col = 0, row = 2
				 */
				// Console.WriteLine("row " + row + ", col " + col + " value: " + grid[row][col]);
				secondary += grid[row][col];
			}

			var difference = Math.Abs(primary - secondary);
			// Console.WriteLine("Difference: |" + primary + " - " + secondary + "| = " + difference);
			Console.WriteLine(difference);
		}
	}
}

