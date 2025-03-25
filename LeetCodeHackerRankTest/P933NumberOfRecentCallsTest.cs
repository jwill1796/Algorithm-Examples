using System;
using LeetCodeHackerRankProbs;
using Shouldly;
using Xunit;

namespace LeetCodeHackerRankTest
{
    public class P933NumberOfRecentCallsTest
    {
        [Theory]
        [InlineData(new int[] { 1, 100, 3001, 3002 }, new int[] { 1, 2, 3, 3 })]
        [InlineData(new int[] { 1, 100, 3001, 3002, 3003, 3004 }, new int[] { 1, 2, 3, 3, 4, 5 })]
        public void PingTest(int[] inputs, int[] expected)
        {
            var numberOfRecentCalls = new P933NumberOfRecentCalls();
            var results = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = numberOfRecentCalls.Ping(inputs[i]);
            }
            results.ShouldBe(expected);
        }
    }
}
