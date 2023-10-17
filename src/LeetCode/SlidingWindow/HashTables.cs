
namespace LeetCode.SlidingWindow;

public class HashTables
{
    

    

    

    

    

    

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
