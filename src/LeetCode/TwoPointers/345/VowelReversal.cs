namespace LeetCode.TwoPointers._345;

public class VowelReversal
{
    public static void Run()
    {
        Console.WriteLine("345. Reverse Vowels: ");
        Console.WriteLine(ReverseVowels("IceCreAm"));
        Console.WriteLine(ReverseVowels("leetcode"));
    }
    
    private static string ReverseVowels(string s) 
    {
        var vowels = new []{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var chars = s.ToCharArray();
        var left = 0;
        var right = chars.Length - 1;
        while (left < right)
        {
            if (vowels.Contains(chars[left]) && vowels.Contains(chars[right]))
            {
                var temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
            else
            {
                if(!vowels.Contains(chars[left]))
                    left++;
                if(!vowels.Contains(chars[right]))
                    right--;
            }
        }
        return new string(chars);
    }
}