using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHackerRankProbs
{
    public class P4MedianofTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    mergedArray[k++] = nums1[i++];
                }
                else
                {
                    mergedArray[k++] = nums2[j++];
                }
            }

            while (i < nums1.Length)
            {
                mergedArray[k++] = nums1[i++];
            }
            while (j < nums2.Length)
            {
                mergedArray[k++] = nums2[j++];
            }

            int n = mergedArray.Length;
            if (mergedArray.Length % 2 == 0)
            {
                return (mergedArray[n / 2] + mergedArray[n / 2 - 1]) / 2.0;
            }
            else
            {
                return mergedArray[n / 2];
            }
        }
    }
}
