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
			for(int i=1; i<arr.Length; i++)
			{
				int insertionIndex = FindInsertionIndex(arr, i);
				ArrayInsert(arr, insertionIndex, i);
			}
		}
		
		private static int FindInsertionIndex(int[] arr, int lastIndex)
		{
			int insertionIndex=0;
			while(insertionIndex<lastIndex && arr[lastIndex]>arr[insertionIndex])
			{
				insertionIndex++;
			}
			
			return insertionIndex;
		}
		
		private static void ArrayInsert(int[] arr, int insertionIndex, int lastIndex)
		{
			int insertionValue = arr[lastIndex];
			for(int i=lastIndex; i>insertionIndex; i--)
			{
				arr[i]=arr[i-1];
			}
			
			arr[insertionIndex]=insertionValue;
		}
	}
}