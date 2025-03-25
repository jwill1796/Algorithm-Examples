using System;
using Shouldly;
using Xunit;
using LeetCodeHackerRankProbs;

namespace LeetCodeHackerRankTest
{
    public class P346MovingAverageFromDataStreamTest
    {
        [Theory]
        [InlineData(new int[] { 1, 10, 3, 5 }, 3, new double[] { 1.0, 5.5, 4.666666666666667, 6.0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2, new double[] { 1.0, 1.5, 2.5, 3.5 })]
        [InlineData(new int[] { 5, 5, 5, 5 }, 1, new double[] { 5.0, 5.0, 5.0, 5.0 })]
        public void MovingAverageTest(int[] inputs, int size, double[] expected)
        {
            var movingAverage = new MovingAverage(size);
            var results = new double[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = movingAverage.Next(inputs[i]);
            }

            results.ShouldBe(expected);
        }

        
    }
}
