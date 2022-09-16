
namespace LeetCode;

public class RansomNotes
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineDic = new Dictionary<char, int>();
        foreach (var c in magazine)
        {
            if(!magazineDic.ContainsKey(c))
                magazineDic.Add(c, 1);
            else
                magazineDic[c]++;

        }
        foreach (var c in ransomNote)
        {
            if (!magazineDic.ContainsKey(c))
                return false;
            if(magazineDic.ContainsKey(c) && magazineDic[c] <= 0)
                return false;
            magazineDic[c]--;
        }

        return true;
    }
}
