using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort
    {
        public static void mergeSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            int midPoint = (end + start) / 2;

            // recursion
            mergeSort(array, start, midPoint);
            mergeSort(array, midPoint + 1, end);
            Merge(array, start, midPoint, end);
        }
        public static void Merge(int[] array, int start, int midpoint, int end)
        {

            int i = 0, j = 0, k = start;

            int leftArrayLength = midpoint - start + 1;
            int RightarrayLength = end - midpoint;

            int[] leftArray = new int[leftArrayLength];
            int[] RightArray = new int[RightarrayLength];

            for (i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[start + i];
            }
            for (j = 0; j < RightarrayLength; j++)
            {
                RightArray[j] = array[midpoint + 1 + j];
            }

            i = 0;
            j = 0;

            k = start;
            while (i < leftArrayLength && j < RightarrayLength)
            {
                if (RightArray[j] <= leftArray[i])
                {
                    array[k] = RightArray[j];
                    j++;
                }
                else
                {
                    array[k] = leftArray[i];
                    i++;
                }
                k++;
            }
            while (leftArrayLength > i)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (RightarrayLength > j)
            {
                array[k] = RightArray[j];
                j++;
                k++;
            }
        }
    }
}
