using System;


namespace CommonAlgorithms 
{
    public static class SortingAlgorithms 
    {
        // O(n^2)
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        // Swap positions
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
        
        // O(n^2)
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++) 
                {
                    if (arr[j] < arr[minIndex]) 
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        // O(n*log(n))
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;

            int[] left = new int[middle];
            int[] right;
            if(arr.Length % 2 == 0)
            {
                right = new int[middle];
            }
            else
            {
                right = new int[middle + 1];
            }

            for(int i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }

            int x = 0;
            for(int i = middle; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] sortedArr = new int[left.Length + right.Length];
            int sortedArrIndex = 0, leftIndex = 0, rightIndex = 0;

            while(leftIndex < left.Length || rightIndex < right.Length)
            {
                if(leftIndex < left.Length && rightIndex < right.Length) 
                {
                    if(left[leftIndex] <= right[rightIndex])
                    {
                        sortedArr[sortedArrIndex] = left[leftIndex];
                        leftIndex++;
                        sortedArrIndex++;
                    }
                    else
                    {
                        sortedArr[sortedArrIndex] = right[rightIndex];
                        rightIndex++;
                        sortedArrIndex++;
                    }
                }
                else if(leftIndex < left.Length)
                {
                    sortedArr[sortedArrIndex] = left[leftIndex];
                    leftIndex++;
                    sortedArrIndex++;
                }
                else if(rightIndex < right.Length) {
                    sortedArr[sortedArrIndex] = right[rightIndex];
                    rightIndex++;
                    sortedArrIndex++;
                }
            }

            return sortedArr;
        }
    }
}