namespace LeetCode.HashTables._205;

public class IsomorphicStrings
{
    public static void Run()
    {
        Console.WriteLine("205. Isomorphic Strings: ");
        // Console.WriteLine(IsIsomorphic("egg", "add"));
        // Console.WriteLine(IsIsomorphic("foo", "bar"));
        // Console.WriteLine(IsIsomorphic("paper", "title"));
        // Console.WriteLine(IsIsomorphic("paper", "ttile"));
        Console.WriteLine(IsIsomorphic("badc", "baba"));
    }
    
    private static bool IsIsomorphic(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;
        
        var letters = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!letters.ContainsKey(s[i]))
            {
                if (letters.ContainsValue(t[i]))
                {
                    return false;
                }

                letters.Add(s[i], t[i]);
            }
            else
            {
                if(letters[s[i]] != t[i])
                    return false;
            }
        }
        return true;
    }
}