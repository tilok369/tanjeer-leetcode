namespace LeetCode.SlidingWindow._187;

public class DnaSequence
{
    public static void Run()
    {
        Console.WriteLine("187. Repeated DNA Sequences: ");
        Console.WriteLine(String.Join(",", DnaSequence.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT")));
        Console.WriteLine(String.Join(",", DnaSequence.FindRepeatedDnaSequences("AAAAAAAAAAAAA")));
        Console.WriteLine(String.Join(",", DnaSequence.FindRepeatedDnaSequences("CCCCAAAAAGGGTTT")));
    }

    public static IList<string> FindRepeatedDnaSequences(string s)
    {
        if (s.Length < 10)
            return new List<string>();
        var sequenceTable = new Dictionary<string, bool>();
        var size = 0;
        var start = 0;
        var index = 0;
        var subSeq = string.Empty;
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
}
