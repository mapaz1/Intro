using System;

namespace Intro.SortingAlgorithms
{
	public class InsertionSort
	{
		public static void Main()
		{
			int[] arr=Utils.GetArray(7);
			Console.WriteLine("--- Insertion Sort ---");
			Console.WriteLine("   arr: [{0}]", string.Join(",",arr));
			DoInsertionSort(arr);	   
			Console.WriteLine("sorted: [{0}]", string.Join(",", arr));
		}
		
		private static void DoInsertionSort(int[] arr)
		{
			for(int sortedSoFar=0; sortedSoFar<arr.Length-1; sortedSoFar++)
			{
				// take first unsorted element and bubble it down to its right position
				for(int i=sortedSoFar+1; i>0 && arr[i] < arr[i-1]; i--)
				{
					Utils.Swap(arr, i, i-1);
				}			
			}
		}
	}
}