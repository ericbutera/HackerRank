using System;

namespace HackerRank
{
	public class SortInsertion01
	{
		public static void Run()
		{
			/* 
			sample input:
			5
			2 4 6 8 3
			
			sample output:
			2 4 6 8 8 
			2 4 6 6 8 
			2 4 4 6 8 
			2 3 4 6 8 
			*/

			int _ar_size;

			_ar_size = Convert.ToInt32(Console.ReadLine());
			int[] _ar = new int[_ar_size];
			String elements = Console.ReadLine();
			String[] split_elements = elements.Split(' ');
			for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
			{
				_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
			}

			insertionSort(_ar);
		}

		public static void insertionSort(int[] numbers)
		{
			// copy last number to a temp variable
			// check next to last cell and see if last cell (size - 2) > temp var
			//   - if so, copy (size - 2) to (size - 1)
			//   - else, set to temp
			// repeat
			// im really not happy with how this turned out.
			var temp = numbers[numbers.Length - 1];

			for (var x = numbers.Length - 2; x >= 0; x--)
			{
				//Console.WriteLine("Testing cell " + x + " value("+ numbers[x] +") > "+ temp);
				if (numbers[x] > temp)
				{
					numbers[x + 1] = numbers[x];
					if (x == 0)
					{
						//Console.WriteLine("last if move, setting");
						Console.WriteLine(string.Join(" ", Array.ConvertAll(numbers, Convert.ToString)));
						numbers[x] = temp;
					}
				}
				else 
				{
					//Console.WriteLine("else block");
					numbers[x + 1] = temp;
					// exit loop because we'd be overwriting numbers that are lower
					Console.WriteLine(string.Join(" ", Array.ConvertAll(numbers, Convert.ToString)));
					break;
				}
				Console.WriteLine(string.Join(" ", Array.ConvertAll(numbers, Convert.ToString)));
			}
		}
	}
}

