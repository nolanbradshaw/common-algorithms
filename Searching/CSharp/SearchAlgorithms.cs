using System; 
namespace CommonAlgorithms 
{
    public static class SearchAlgorithms 
    {
        // O(n)
        // Returns the index of the element (null if not found).
        public static int? LinearSearch(int[] arr, int termToFind)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == termToFind)
                {
                    return i;
                }
            }

            return null;
        }

        // O (log(n))
        // Assumes a sorted array.
        // Returns the index of the element (null if not found.)
        public static int? BinarySearch(int[] arr, int termToFind) 
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max) 
            {
                int middle = (max + min) /2;
                if(termToFind == arr[middle]) 
                {
                    return middle;
                }
                else if (termToFind < arr[middle]) 
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }
            // Element not found.
            return null;
        }
    }
}