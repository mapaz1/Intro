using System;

namespace Intro.SortingAlgorithms
{
	public class MergeSort
	{
		public static void Main()
		{
			int[] arr= Utils.GetArray(7);
			Console.WriteLine("--- Merge Sort ---");
			Console.WriteLine("   arr: [{0}]", string.Join(",", arr));
			DoMergeSort(arr);	   
			Console.WriteLine("sorted: [{0}]", string.Join(",", arr));
		}
		
		private static void DoMergeSort(int[] arr)
		{
            if(arr.Length < 2)
            {
                return;
            }

			int mid = arr.Length / 2;
            int[] left = ArraySubsequesce(arr, 0, mid);
            int[] right = ArraySubsequesce(arr, mid, arr.Length);
            DoMergeSort(left);
            DoMergeSort(right);
            Merge(arr, left, right);
		}

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i=0, j=0, totalLength = left.Length + right.Length;
            for(int k=0; k<totalLength; k++)
            {
                if(i<left.Length && j<right.Length)
                {
                    if(left[i]<right[j])
                    {
                        arr[k] = left[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = right[j];
                        j++;
                    }
                }
                else if(i<left.Length)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
            }
        }

        private static int[] ArraySubsequesce(int[] arr, int start, int end)
        {
            int[] res = new int[end-start];
            for(int i=start; i<end; i++)
            {
                res[i-start] = arr[i];
            }

            return res;
        }
    }
}