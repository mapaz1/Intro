using System;

namespace Intro.SortingAlgorithms
{
    public static class Utils
    {
        public static int[] GetArray(int length)
        {
            int[] arr = new int[length];
            Random rand = new Random();

            for (int i=0; i<length; i++)
            {
                arr[i] = rand.Next(100);
            }
            
            return arr;
        }
        
		public static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

        public static bool IsSorted(int[] arr)
        {
            bool sorted = true;
            for(int i=0; i<arr.Length-1 && sorted; i++)
            {
                if(arr[i]>arr[i+1])
                {
                    sorted = false;
                }
            }

            return sorted;
        }
    }
}
