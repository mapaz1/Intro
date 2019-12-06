using System;

namespace Intro.SortingAlgorithms
{
	public class SelectionSort
	{
		public static void Main()
		{
			int[] arr= Utils.GetArray(7);
			Console.WriteLine("--- Selection Sort ---");
			Console.WriteLine("   arr: [{0}]", string.Join(",", arr));
			DoSelectionSort(arr);	   
			Console.WriteLine("sorted: [{0}]", string.Join(",", arr));
		}
		
		private static void DoSelectionSort(int[] arr)
		{
			for(int i=0; i<arr.Length-1; i++)
			{
				int iMin = FindMinIndex(arr, i);
				Swap(arr, i, iMin);
			}
		}
		
		private static int FindMinIndex(int[] arr, int startIndex=0)
		{
			int minIndex=startIndex;
			for (int i=startIndex+1; i<arr.Length; i++)
			{
				if(arr[i]<arr[minIndex])
				{
					minIndex=i;
				}
			}
			
			return minIndex;
		}
		
		private static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}	
	}
}