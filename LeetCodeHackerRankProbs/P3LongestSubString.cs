using System;
using System.Collections.Generic;

// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class LongestSubString
{
    public int LengthOfLongestSubstring(string s)
    {
        int _max = 0;
        int _currentIndex = 0;
        Dictionary<char, int> _charIndexMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (_charIndexMap.ContainsKey(s[i]))
            {
                _currentIndex = Math.Max(_currentIndex, _charIndexMap[s[i]] + 1);
            }
            _charIndexMap[s[i]] = i;
            _max = Math.Max(_max, i - _currentIndex + 1);
        }
        return _max;
    }
}
