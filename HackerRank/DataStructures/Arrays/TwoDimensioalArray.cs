using System;

namespace HackerRank
{
	public class TwoDimensioalArray
	{
		public const int SEARCH_MAX_COLUMN = 4;
		public const int SEARCH_MAX_ROW = 4;
		public const int GRID_MAX_COLUMN = 5;
		public const int GRID_MAX_ROW = 5;

		public static void Run()
		{
			/*
			string[] input1 = {
				"1 1 1 0 0 0",
				"0 1 0 0 0 0",
				"1 1 1 0 0 0",
				"0 0 2 4 4 0",
				"0 0 0 2 0 0",
				"0 0 1 2 4 0" }; // 19 at row 3 col 2

			string[] input2 = {
				"1 1 1 0 0 0",
				"0 1 0 0 0 0",
				"1 1 1 0 0 0",
				"0 9 2 -4 -4 0",
				"0 0 0 -2 0 0",
				"0 0 -1 -2 -4 0" }; // 13 at row 1 col 0

			string[] input3 = {
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0" }; // no hourglass

			string[] input4 = {
				"0 0 0 0 0 0",
				"0 5 5 5 0 0",
				"0 0 5 0 0 0",
				"0 5 5 5 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0" }; // 35 at row 1 col 1
			*/
			string[] input5 = {
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 0 0 0",
				"0 0 0 5 5 5",
				"0 0 0 0 5 0",
				"0 0 0 5 5 5" }; // 35 at row 3 col 3

			// read from a pre-defined array
			var input = input5;

			/* uncomment if you want to run on the website
			// read from standard input
			var rows = GRID_MAX_ROW + 1;
			var input = new string[rows];

			for (var x = 0; x < rows; x++)
				input[x] = Console.ReadLine();
			*/

			var grid = CreateGrid(input);
			var largest = FindLargestHourglass(grid);
			Console.WriteLine(largest);
		}

		/// <summary>
		/// turn text input into a multi dimensional array
		/// </summary>
		/// <returns>The grid.</returns>
		/// <param name="rows">Input.</param>
		public static int[,] CreateGrid(string[] rows)
		{
			if (rows.Length - 1 != GRID_MAX_COLUMN)
				throw new ArgumentException("You must have " + (GRID_MAX_ROW + 1) + " to use this program");
			
			int[] columns;
			int[,] grid = new int[GRID_MAX_COLUMN + 1, GRID_MAX_ROW + 1];

			for (int row = 0; row <= GRID_MAX_ROW; row++)
			{
				columns = Array.ConvertAll(rows[row].Split(' '), Int32.Parse);

				if (columns.Length - 1 != GRID_MAX_COLUMN) 
					throw new ArgumentException("Invalid column length on row " + row);

				for (int column = 0; column <= GRID_MAX_COLUMN; column++)
				{
					grid[column, row] = columns[column];
				}
			}

			return grid;
		}

		/// <summary>
		/// Finds the largest hourglass. If the hourglass shape changes (as in grows) update the logic to use an array of offsets 
		/// instead of hard coding a top, middle, bottom.
		/// </summary>
		/// <returns>The largest hourglass.</returns>
		/// <param name="grid">Grid - int[column, row].</param>
		/// 
		public static int FindLargestHourglass(int[,] grid)
		{
			int total = int.MinValue // we need to allow negative numbers such as -6 in the scenarios
				, currentTotal
				, column
				, row;

			for (var currentRow = 0; currentRow < SEARCH_MAX_ROW; currentRow++)
			{
				for (var currentColumn = 0; currentColumn < SEARCH_MAX_COLUMN; currentColumn++)
				{
					currentTotal = 0;

					// add top of hour glass
					row = currentRow;
					for (column = currentColumn; column <= currentColumn + 2; column++)
					{
						//Console.WriteLine("TOP: Adding total += grid[col:" + column + ", row:" + row + "] ("+ grid[column, row] +")"); 
						currentTotal += grid[column, row];
					}

					// add middle of hourglass
					column = currentColumn + 1;
					row = currentRow + 1;
					//Console.WriteLine("MIDDLE: total += grid[col:" + column + ", row:" + row + "] (" + grid[column, row] + ")");
					currentTotal += grid[column, row];

					// add bottom of hourglass
					row = currentRow + 2;
					for (column = currentColumn; column <= currentColumn + 2; column++)
					{
						//Console.WriteLine("BOTTOM: Adding total += grid[col:" + column + ", row:" + row + "] (" + grid[column, row] + ")");
						currentTotal += grid[column, row];
					}

					//Console.WriteLine("[col:"+ currentColumn +", row:"+ currentRow +"] currentTotal["+ currentTotal +"] total[" + total + "]");
					if (currentTotal > total)
					{
						// Console.WriteLine("Updating total");
						total = currentTotal;
					}
				}
			}

			return total;
		}
	}
}

