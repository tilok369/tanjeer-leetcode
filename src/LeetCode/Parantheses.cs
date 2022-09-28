
namespace LeetCode;

public class Parantheses
{
    public static bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        {
            return false;
        }
        var paranthesesStack = new Stack<char>();
        var paranthesesDic = new Dictionary<char, char>() { {')', '(' }, { '}', '{' }, { ']', '[' } };

        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                paranthesesStack.Push(c);
            else
            { 
                if(paranthesesStack.Count == 0)
                    return false;
                var parathese = paranthesesStack.Pop(); 
                if(parathese != paranthesesDic[c])
                    return false;
            }
        }

        return paranthesesStack.Count == 0;
    }
}
