using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static int[] test = { 31, 41,234,342, 59, 26, 41, 58 , 1, 1, 2, 3, 123 ,4213 ,12, 31 };

        static void Main(string[] args)
        {
            int [] res = MergeSort(test);
            foreach (int item in res)
            {
                Console.Write(item + "  ");
            }
            Console.Read();
        }

        public static int[] Merge(int [] left, int [] right)
        {
            //Console.WriteLine(left.Length + "  " + right.Length);
            int [] res = new int[left.Length+right.Length];
            int i = 0, j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    res[i+j] = left[i];
                    i++;
                }
                else
                {
                    res[i + j] = right[j];
                    j++;
                }
                
            }
            for (int k = i + j; k < res.Length; k++)
            {
                //Console.WriteLine(i + "  " + j);
                if (i < left.Length )
                {
                    res[k] = left[k - j];
                }
                else
                {
                    res[k] = right[k - i];
                }
            }
            return res;
        }
        public static int [] MergeSort(int [] test)
        {
            if(test.Length == 0 || test.Length ==1)
                return test;
            int p = test.Length / 2;
            int[] left = new int[p];
            int[] right = new int[test.Length - p];
            for (int i = 0; i < p; i++ )
            {
                left[i] = test[i];
            }
            for (int i = p; i < test.Length; i++)
            {
                right[i - p] = test[i];
            }
            left = MergeSort(left);
            right = MergeSort(right);
            return  Merge(left, right);
        }
    }
}
