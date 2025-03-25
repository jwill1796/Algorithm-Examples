using System;
using Shouldly;
using Xunit;
using LeetCodeHackerRankProbs;

namespace LeetCodeHackerRankTest
{
    public  class P4MedianOfTwoSortedArraysTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]

        public void FindMedianSortedArraysTest(int[] nums1, int[] nums2, double expected)
        {
            var medianOfTwoSortedArrays = new P4MedianofTwoSortedArrays();
            var result = medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
            result.ShouldBe(expected);
        }
    }
}
