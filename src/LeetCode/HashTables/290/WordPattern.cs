namespace LeetCode.HashTables._290;

public class WordPattern
{
    public static void Run()
    {
        Console.WriteLine("290. WordPattern: ");
        Console.WriteLine(WordPatternMatch("abba", "dog cat cat dog"));
        Console.WriteLine(WordPatternMatch("abba", "dog cat cat fish"));
        Console.WriteLine(WordPatternMatch("aaaa", "dog cat cat dog"));
        Console.WriteLine(WordPatternMatch("abba", "dog dog dog dog"));
        Console.WriteLine(WordPatternMatch("aaa", "dog dog dog dog"));
    }
    
    private static bool WordPatternMatch(string pattern, string s) 
    {
        var matchTable = new Dictionary<char, string>();
        var words = s.Split(' ');
        var index = 0;
        if(words.Length != pattern.Length)
            return false;
        foreach (var c in pattern)
        {
            if (!matchTable.ContainsKey(c))
            {
                if(matchTable.ContainsValue(words[index]))
                    return false;
                matchTable.Add(c, words[index++]);
            }
            else
            {
                if(matchTable[c] != words[index++])
                    return false;
            }
        }
        
        return true;
    }
}