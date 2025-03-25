using System;
using Shouldly;
using Xunit;
using LeetCodeHackerRankProbs;

public class LongestSubStringTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData("dvdf", 3)]
    public void LengthOfLongestSubstring_ShouldReturnCorrectLength_WhenStringIsGiven(string s, int expected)
    {
        // Arrange 
        var longestSubString = new LongestSubString();

        // Act
        var result = longestSubString.LengthOfLongestSubstring(s);

        // Assert
        result.ShouldBe(expected);
    }
}