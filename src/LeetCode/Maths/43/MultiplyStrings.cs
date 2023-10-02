namespace LeetCode.Maths._43;

public class MultiplyStrings
{
    public static void Run()
    {
        Console.WriteLine("43. Multiply Strings: ");
        Console.WriteLine(MultiplyStrings.Multiply("123", "456"));
        Console.WriteLine(MultiplyStrings.Multiply("2", "3"));
        Console.WriteLine(MultiplyStrings.Multiply("999", "999"));
        Console.WriteLine(MultiplyStrings.Multiply("12345", "100"));
        Console.WriteLine(MultiplyStrings.Multiply("9133", "0"));
    }

    public static string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";
        var multiplyList = new List<List<int>>();
        var zeros = new List<int>();
        for (var i = num1.Length - 1; i >= 0; i--)
        {
            var list = new List<int>();
            list.AddRange(new List<int>(zeros));
            var carry = 0;
            for (var j = num2.Length - 1; j >= 0; j--)
            {
                var n1 = (int)num1[i] - 48;
                var n2 = (int)num2[j] - 48;
                list.Add(carry + (n1 * n2) % 10);
                carry = (n1 * n2) / 10;
            }
            if (carry > 0)
                list.Add(carry);
            multiplyList.Add(list);
            zeros.Add(0);
        }

        var max = multiplyList.Select(x => x.Count).Max();
        var result = new List<string>();
        var carry2 = 0;
        for (var k = 0; k < max; k++)
        {
            var sum = multiplyList.Sum(x => k <= x.Count - 1 ? x[k] : 0);
            result.Add(((carry2 + sum) % 10) + "");
            carry2 = (carry2 + sum) / 10;
        }
        if (carry2 > 0)
            result.Add(carry2 + "");

        result.Reverse();
        return string.Join("", result);
    }
}
