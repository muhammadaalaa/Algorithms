using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SortedCharactersFreq
    {
        #region mensio 
        //public void mentionedLettersAtWard(string message)
        //{
        //    int[] ASCIArray = new int[127];
        //    // conver the letters of the message into asci Code
        //    for (int i = 0; i < message.Length; i++)
        //    {
        //        int index = (int)message[i];
        //        ASCIArray[index]++;
        //    }
        //    for (int i = 0; i < ASCIArray.Length; i++)
        //    {
        //        if (ASCIArray[i] > 0)
        //        {
        //            char c = (char)i;
        //            //Console.Write(c);
        //            Console.Write(c + " ");
        //            Console.WriteLine(ASCIArray[i]);
        //        }
        //    }

        //} 
        #endregion
        #region creating hashtable for calc the nums of the letters in the message


        // will loop at the message 
        // will stord the letters at hash table
        // key for letters and value for mentions times
        // if the letter is exist at the hash table will increment the value by one 
        //if not will set one
        public static void HashTableForCalcTheLetteres(string message)
        {
            Hashtable MentionedIthem = new Hashtable();
            for (int i = 0; i < message.Length; i++)
            {
                if (MentionedIthem[message[i]] == null)
                {
                    MentionedIthem[message[i]] = 1;
                }
                else
                {
                    MentionedIthem[message[i]] = (int)MentionedIthem[message[i]] + 1;
                }
            }
            //foreach (char item in MentionedIthem.Keys)
            //{
            //    Console.Write(item + " ");
            //    Console.WriteLine(MentionedIthem[item]);
            //}

            sortHash(MentionedIthem);
        }
        public static void sortHash(Hashtable hash)
        {
            int[,] sortHashed = new int[hash.Count, 2];
            int i = 0;
            foreach (char k in hash.Keys)
            {
                sortHashed[i, 0] = (int)k;
                sortHashed[i, 1] = (int)hash[k];
                i++;
            }


            MergeSort(sortHashed, 0, hash.Count - 1);


            Console.WriteLine("Print Sorted data ...");
            for (i = 0; i < hash.Count; i++)
            {
                Console.Write((char)sortHashed[i, 0] + " ");
                Console.WriteLine(sortHashed[i, 1]);
            }
        }


        // to sort the hashTable we will use the mergesort
        public static void MergeSort(int[,] arr, int start, int end)
        {
            if (start >= end) return;

            int midPoint = (start + end) / 2;
            MergeSort(arr, start, midPoint);
            MergeSort(arr, midPoint + 1, end);
            Merge(arr, start, midPoint, end);
        }
        public static void Merge(int[,] arr, int start, int midPoint, int end)
        {
            // that will be two Dimension array 
            int i, j, k;

            int lengthOfLeftArr = midPoint - start + 1;
            int lengthOfRightArr = end - midPoint;

            int[,] leftArr = new int[lengthOfLeftArr, 2];
            int[,] RightArr = new int[lengthOfRightArr, 2];

            for (i = 0; i < lengthOfLeftArr; i++)
            {
                leftArr[i, 0] = arr[start + i, 0];
                leftArr[i, 1] = arr[start + i, 1];
            }
            for (j = 0; j < lengthOfRightArr; j++)
            {
                RightArr[j, 0] = arr[midPoint + j + 1, 0];
                RightArr[j, 1] = arr[midPoint + j + 1, 1];
            }
            i = j = 0;
            k = start;
            while (i < lengthOfLeftArr && j < lengthOfRightArr)
            {
                if (leftArr[i, 1] > RightArr[j, 1])
                {
                    arr[k, 0] = RightArr[j, 0];
                    arr[k, 1] = RightArr[j, 1];
                    j++;
                }
                else
                {
                    arr[k, 0] = leftArr[i, 0];
                    arr[k, 1] = leftArr[i, 1];
                    i++;
                }
                k++;
            }
            while (i < lengthOfLeftArr)
            {
                arr[k, 0] = leftArr[i, 0];
                arr[k, 1] = leftArr[i, 1];
                k++;
                i++;
            }
            while (j < lengthOfRightArr)
            {
                arr[k, 0] = RightArr[j, 0];
                arr[k, 1] = RightArr[j, 1];
                j++;
                k++;
            }
        }
        #endregion
    }
}
