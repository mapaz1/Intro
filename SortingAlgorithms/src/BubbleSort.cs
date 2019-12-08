using System;

namespace Intro.SortingAlgorithms
{
	public class BubbleSort
	{
		public static void Main()
		{
			int[] arr= Utils.GetArray(7);
			Console.WriteLine("--- Bubble Sort ---");
			Console.WriteLine("   arr: [{0}]", string.Join(",", arr));
			DoBubbleSort(arr);	   
			Console.WriteLine("sorted: [{0}]", string.Join(",", arr));
		}

        public static void DoBubbleSort(int[] arr)
        {
            for (int i=0; i<arr.Length; i++)
			{
				BubbleLargestUp(arr, arr.Length-i);
			}
        }

		public static void BubbleLargestUp(int[] arr, int endIndex)
		{
			for(int i=0; i<endIndex-1; i++)
			{
				if(arr[i]>arr[i+1])
				{
					Utils.Swap(arr, i, i+1);
				}
			}
		}
    }
}