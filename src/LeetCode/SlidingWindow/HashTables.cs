﻿
namespace LeetCode.SlidingWindow;

public class HashTables
{
    public static int LengthOfLongestSubstring(string s)
    { 
        Dictionary<char, int> hashTable = new Dictionary<char, int>();
        int start = 0;
        int length = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (hashTable.ContainsKey(s[end]))
            {
                start = Math.Max(start, hashTable[s[end]] + 1);
                hashTable[s[end]] = end;
            }
            else
            {
                hashTable.Add(s[end], end);
            }

            length = Math.Max(length, end - start + 1);
        }

        return length;
    }

    public static IList<string> FindRepeatedDnaSequences(string s)
    {
        if(s.Length < 10)
            return new List<string>();
        var sequenceTable = new Dictionary<string, bool>();
        var size = 0;
        var start = 0;
        var index = 0;
        var subSeq=string.Empty;
        for (start = 0; start < s.Length; start++)
        {
            subSeq += s[start];
            size++;
            if (size == 10)
            {
                if (sequenceTable.ContainsKey(subSeq))
                    sequenceTable[subSeq] = true;
                else
                    sequenceTable.Add(subSeq, false);
                size = 0;
                start = index++;
                subSeq = string.Empty;
            }
        }
        return sequenceTable.Where(i => i.Value).Select(i => i.Key).ToList();
    }

    public static int MinSubArrayLen(int target, int[] nums)
    {
        var sum = 0;
        var len = int.MaxValue;
        var size = 0;
        var index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum+=nums[i];
            size++;
            if (sum >= target)
            {
                len = Math.Min(len, size);
                size = 0;
                sum = 0;
                i = index++;
            }
        }

        return len == int.MaxValue ? 0 : len;
    }

    public static int MinSubArrayLen2(int target, int[] nums)
    {
        var sum = 0;
        var len = int.MaxValue;
        var start = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= target)
            {
                len = Math.Min(len, i- start + 1);
                sum-=nums[start++];
            }
        }

        return len == int.MaxValue ? 0 : len;
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numDic.ContainsKey(nums[i]))
            { 
                if(i - numDic[nums[i]] <= k)
                    return true;
                else
                    numDic[nums[i]] = i;
            }
            else
                numDic.Add(nums[i], i);
        }
        return false;
    }

    public bool ContainsDuplicate(int[] nums)
    {
        var numDic = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (numDic.ContainsKey(num))
                return true;
            numDic.Add(num, 0);
        }

        return false;
    }

    public static IList<int> FindAnagrams(string s, string p)
    {
        var anLen = p.Length;
        var start = 0;
        var anDic = new Dictionary<char, int>();
        var indexes = new List<int>();
        foreach (var c in p)
        {
            if (!anDic.ContainsKey(c))
                anDic.Add(c, 1);
            else
                anDic[c]++;
        }

        var currLen = 0;
        var found = true;
        for (var end = 0; end < s.Length; end++)
        {
            currLen++;
            if (anDic.ContainsKey(s[end]))
                anDic[s[end]]--;

            if (currLen == anLen)
            {
                if(anDic.All(a => a.Value == 0))
                    indexes.Add(start);
                if (anDic.ContainsKey(s[start]))
                    anDic[s[start]]++;
                start++;
                currLen--;
            }

            

        }

        return indexes;
    }

    public static int CountGoodSubstrings(string s)
    {
        var hashTable = new Dictionary<char, int>();
        var start = 0;
        var index = 0;
        var good = 0;
        for (int end = 0; end < s.Length; end++)
        {
            if(hashTable.ContainsKey(s[end]))
                hashTable[s[end]]++;
            else
                hashTable.Add(s[end], 1);
            index++;

            if (index == 3)
            {
                if(!hashTable.Any(i=>i.Value > 1))
                    good++;
                if(hashTable.ContainsKey(s[start]))
                    hashTable[s[start]]--;
                start++;
                index--;
            }
        }

        return good;
    }
}