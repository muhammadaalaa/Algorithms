using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class segregate
    {
        #region segergate with merge sort
        public static void Segregate(int[] arr, int start, int end)
        {
            if (start >= end) return;

            int midPoint = (start + end) / 2;
            Segregate(arr, start, midPoint);
            Segregate(arr, midPoint + 1, end);
            merge(arr, start, midPoint, end);
        }
        public static void merge(int[] arr, int start, int midPoint, int end)
        {
            int i, j, k;
            int Left_ArrayLength = midPoint - start + 1;
            int Right_ArrayLength = end - midPoint;

            int[] LeftArray = new int[Left_ArrayLength];
            int[] RightArray = new int[Right_ArrayLength];

            for (i = 0; i < Left_ArrayLength; i++)
            {
                LeftArray[i] = arr[i + start];
            }
            for (j = 0; j < Right_ArrayLength; j++)
            {
                RightArray[j] = arr[j + midPoint + 1];
            }
            i = j = 0;
            k = start;
            while (Left_ArrayLength > i && LeftArray[i] <= 0)
            {
                arr[k++] = LeftArray[i++];
            }
            while (Right_ArrayLength > j && RightArray[j] <= 0)
            {
                arr[k++] = RightArray[j++];
            }
            while (Left_ArrayLength > i)
            {
                arr[k++] = LeftArray[i++];
            }
            while (Right_ArrayLength > j)
            {
                arr[k++] = RightArray[j++];
            }

        }
        #endregion
        #region segregate with general way
        //[-2,3,-4,-5,6]
        // two arrayer one for neg and one for pos 
        // loop in this arr if you fing neg add to neg if you find pos add to pos 
        public static List<int> normalSegerate(int[] arr)
        {
            List<int> n = new List<int>();
            List<int> p = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    n.Add(arr[i]);
                }
                else
                {
                    p.Add(arr[i]);
                }
            }
            foreach (var item in p)
            {
                n.Add(item);
            }
            return n;
        }




        #endregion

    }
}
