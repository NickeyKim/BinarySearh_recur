using System;

namespace BinarySearh_recur
{
	public class BinarySearch 
	{

		public static int binarySearch(int[] array, int target) {
			try
			{
				return binarySearch(array, target, 0, array.Length - 1);
			}
			catch{
				throw;
			}

		}

		private static int binarySearch(int[] array, int target, int lower, int upper){
			int range = upper - lower;
			if (range < 0) {
				throw new Exception("Limits reversed.");
			} else if (range == 0 && array[lower] != target) {
				throw new Exception("Target element no found.");
			}
			if (array[lower] > array[upper]) {
				throw new Exception("Array not sorted.");
			}

			int center = range / 2 + lower;
			if (array[center] == target) {
				return center;
			} else if (array[center] > target) {
				return binarySearch(array, target, lower, center - 1);
			} else {  //(array[center] > target)
				return binarySearch(array, target, center + 1, upper);
			}
		}

		public static void Main(string[] args) {
			int[] testArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
			try {
				Console.WriteLine(binarySearch(testArray, 6));

			} catch (Exception e) {
				Console.WriteLine(e.ToString());
			}
		}
	}
}
