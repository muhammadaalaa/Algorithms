

using Algorithms;

public class program
{
    public static void Main(string[] args)
    {
        #region MergeSort
        //divide and conquer
        //devide
        //conquer 
        //combine
        //Analusis Methods
        // recursion tree mrthod && master Method
        // recusriontree when i have n how many levels i can get  
        // k is the last level   ==> the count is equal k+1
        // scientests found that k=2 when n is equal 4 and every time you doubled the n you will find out that k increases by one level 
        // they reach to the eq to calc the k = log n
        // each level have numbers of operations so 
        // to calc total nums of operation will be n * logn  ==>O(NlogN)
        //int start = 0;
        //int[] arr = { 4543, 53, 364, 234, 536, 47, 6, 78587 };
        //MergeSort.mergeSort(arr, start, arr.Length - 1);
        //Console.WriteLine("[" + String.Join(", ", arr) + "]"); 
        #endregion
        #region exmple about merge sort

        //int[] test = { -1, 8, -5, 6, -1, 6, -1 };
        //segregate.Segregate(test, 0, test.Length - 1);
        //List<int> result = segregate.normalSegerate(test);

        //Console.WriteLine(string.Join(", ", result));
        //Console.WriteLine(string.Join(", ", test));


        #endregion

        string message = "The output from Huffman's algorithm can be viewed as a variable length code table for encoding a source symbol. The algorithm derives this table from the estimated probability or frequency of occurrence for each possible value of the source symbol. as in other entropy encoding methods, more common symbols are generally represented using fewer bits than less common symbols. Huffman's method can be efficiently implemented, finding a code in time linear to the number of input weights if these weights are sorted. However, although optimal among methods encoding symbols separately, Huffman coding is not always optimal among all compression methods it is replaced with arithmetic coding or asymmetric numeral systems if better compression ratio is required.";

        #region withAsciCode
        //SortedCharactersFreq sortedCharactersFreq = new SortedCharactersFreq();
        //sortedCharactersFreq.mentionedLettersAtWard(message); 
        #endregion
        #region WithHashTable
        Algorithms.SortedCharactersFreq.HashTableForCalcTheLetteres(message);
        #endregion


    }

}