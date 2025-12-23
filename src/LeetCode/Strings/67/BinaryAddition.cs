namespace LeetCode.Strings._67;

public class BinaryAddition
{
    public static void Run()
    {
        Console.WriteLine("67. Add Binary: ");
        Console.WriteLine(AddBinary("11", "1"));
        Console.WriteLine(AddBinary("1010", "1011"));
        Console.WriteLine(AddBinary("10", "1000"));
        Console.WriteLine(AddBinary("1111", "1111"));
    }
    
    private static string AddBinary(string a, string b) 
    {
        var result = string.Empty;
        var maxLength = Math.Max(a.Length, b.Length) - 1;
        var carry = '0';
        var aLength = a.Length - 1; 
        var bLength = b.Length - 1; 
        while (maxLength >= 0)
        {
            var n1 = aLength >= 0 ? a[aLength] : '0';
            var n2 = bLength >= 0 ? b[bLength] : '0';
            var subSum = Sum(n1, n2, carry);
            result = subSum.sum + result;
            carry = subSum.carry;
            aLength--;
            bLength--;
            maxLength--;
        }
        
        if(carry == '1')
            result = "1" + result;
        return result;
    }

    private static (char sum, char carry) Sum(char n1, char n2, char carry)
    {
        var addition = int.Parse(n1.ToString()) + int.Parse(n2.ToString()) + int.Parse(carry.ToString());
        
        return addition == 0 
            ? ('0', '0') 
            : addition == 1 
                ? ('1', '0') 
                : addition == 2 
                    ? ('0', '1') 
                    : ('1', '1');
    }
    
    // sum  = a XOR b
    // carry = (a AND b) << 1
    /********************************
     * 1.	Start from the rightmost bit
       2.	Convert characters '0' / '1' to integers
       3.	Apply:
       •	sumBit = bitA ^ bitB ^ carry
       •	carry = (bitA & bitB) | (carry & (bitA ^ bitB))
       4.	Prepend the result bit
       5.	Continue until all bits + carry are processed
     */
    public string AddBinaryBitManupulation(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        var result = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int bitA = (i >= 0) ? a[i--] - '0' : 0;
            int bitB = (j >= 0) ? b[j--] - '0' : 0;

            // XOR gives sum bit
            int sumBit = bitA ^ bitB ^ carry;

            // Carry using bit logic
            carry = (bitA & bitB) | (carry & (bitA ^ bitB));

            result.Insert(0, sumBit);
        }

        return result.ToString();
    }
}