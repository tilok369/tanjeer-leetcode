// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Arrays._26;
using LeetCode.Arrays._27;
using LeetCode.Arrays._34;
using LeetCode.Arrays._35;
using LeetCode.Arrays._704;
using LeetCode.Backtracking._17;
using LeetCode.Backtracking._22;
using LeetCode.Backtracking._31;
using LeetCode.Backtracking._39;
using LeetCode.DFS;
using LeetCode.DFS._200;
using LeetCode.DFS._733;
using LeetCode.DynamicProgramming._516;
using LeetCode.Greedy._11;
using LeetCode.HashTables._1;
using LeetCode.HashTables._12;
using LeetCode.HashTables._13;
using LeetCode.HashTables._15;
using LeetCode.HashTables._16;
using LeetCode.HashTables._18;
using LeetCode.HashTables._383;
using LeetCode.LinkList;
using LeetCode.LinkList._19;
using LeetCode.LinkList._2;
using LeetCode.LinkList._206;
using LeetCode.LinkList._21;
using LeetCode.LinkList._234;
using LeetCode.LinkList._24;
using LeetCode.LinkList._876;
using LeetCode.Maths._1342;
using LeetCode.Maths._29;
using LeetCode.Maths._7;
using LeetCode.Maths._9;
using LeetCode.Matrix._1337;
using LeetCode.Matrix._1672;
using LeetCode.Matrix._36;
using LeetCode.Recursion;
using LeetCode.Recursion._38;
using LeetCode.SlidingWindow;
using LeetCode.SlidingWindow._3;
using LeetCode.Stack._20;
using LeetCode.Strings._14;
using LeetCode.Strings._412;
using LeetCode.Strings._6;
using LeetCode.Strings._8;
using LeetCode.TwoPointers._28;



//1
//TwoSums.Run();
//2
//AddTwoNumbersLinkList.Run();
//3
//LongestSubstringWithoutRepeatingCharacters.Run();
//6
//ZigzagConversion.Run();
//7
//ReverseInteger.Run();
//8
//StringToInteger.Run();
//9
//PalindromNumber.Run();
//11
//ContainerWithMostWater.Run();
//12
//IntegerToRoman.Run();
//13
//RomanToInteger.Run();
//14
//LongestCommon.Run();
//15
//ThreeSums.Run();
//16
//ThreeSumsClosest.Run();
//17
//LetterCombinationsPhone.Run();
//18
//FourSums.Run();
//19
//RemoveNthNode.Run();
//20
//ValidParantheses.Run();
//21
//MergeList.Run();
//22
//GenerateParentheses.Run();
//24
//SwapNodes.Run();
//26
//RemoveArrayDuplicates.Run();
//27
//RemoveArrayElement.Run();
//28
//FindFirstOccurrence.Run();
//29
//DivideTwoIntegers.Run();
//31
//NextPermutation.Run();
//34
//FirstLastElement.Run();
//35
//SearchInsertPosition.Run();
//36
//Sudoku.Run();
//38
//CountSay.Run();
//39
//CombiSum.Run();
//234
//PalindromeLinkList.Run();
//383
//RansomNotes.Run();
//412
//FizzBuzzs.Run();
//516
//LongestPalindromicSubsequence.Run();
//704
//BinarySearch.Run();
//876
//MiddleNodeLinkList.Run();
//1337
//KWeakestRowsMatrix.Run();
//1342
//ReduceNumberToZero.Run();
//1672
//RichestCustomerWealth.Run();































//Console.WriteLine("Multiply Strings: ");
//Console.WriteLine(Maths.Multiply("123", "456"));
//Console.WriteLine(Maths.Multiply("2", "3"));
//Console.WriteLine(Maths.Multiply("999", "999"));
//Console.WriteLine(Maths.Multiply("12345", "100"));
//Console.WriteLine(Maths.Multiply("9133", "0"));

//Console.WriteLine("Jump Game II: ");
//Console.WriteLine(Arrays.Jump2(new int[] { 2, 3, 1, 1, 4 }));
//Console.WriteLine(Arrays.Jump(new int[] { 2, 3, 1, 1, 4, 2, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 2 }));
//Console.WriteLine(Arrays.Jump(new int[] { 0, 2, 3 }));
//Console.WriteLine(Arrays.Jump(new int[] { 2, 3, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 3, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 1, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 0, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 1, 2, 1, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 1, 1, 1, 1 }));
//Console.WriteLine(Arrays.Jump(new int[] { 1, 2, 1, 1, 1 }));
//Console.WriteLine(Arrays.Jump2(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 0 }));

//Console.WriteLine("Permutations: ");
//Console.WriteLine(string.Join("|", Recursions.Permute(new int[] { 1, 2, 3 }).Select(i => string.Join(",", i))));
//Console.WriteLine(string.Join("|", Recursions.Permute(new int[] { 0, 1 }).Select(i => string.Join(",", i))));
//Console.WriteLine(string.Join("|", Recursions.Permute(new int[] { 1 }).Select(i => string.Join(",", i))));
//Console.WriteLine(string.Join("|", Recursions.Permute(new int[] { 2, 2, 1, 1 }).Select(i => string.Join(",", i))));

//Console.WriteLine("Permutations ||: ");
//Console.WriteLine(string.Join("|", Recursions.PermuteUnique(new int[] { 1, 1, 2 }).Select(i => string.Join(",", i))));
//Console.WriteLine(string.Join("|", Recursions.PermuteUnique(new int[] { 2, 2, 1, 1 }).Select(i => string.Join(",", i))));

//Console.WriteLine("Group Anagrams: ");
//Console.WriteLine(string.Join("|", Strings.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }).Select(x => string.Join(",", x))));
//Console.WriteLine(string.Join("|", Strings.GroupAnagrams(new string[] { "" }).Select(x => string.Join(",", x))));
//Console.WriteLine(string.Join("|", Strings.GroupAnagrams(new string[] { "a" }).Select(x => string.Join(",", x))));

//Console.WriteLine("Pow(x, n): ");
//Console.WriteLine(Maths.MyPow(2.0000, 10));
//Console.WriteLine(Maths.MyPow(2.1000, 3));
//Console.WriteLine(Maths.MyPow(2.0000, -2));
//Console.WriteLine(Maths.MyPowOpt(2.0000, 10));
//Console.WriteLine(Maths.MyPowOpt(2.1000, 3));
//Console.WriteLine(Maths.MyPowOpt(2.0000, -2));

//var mat = new int[][] {
//    new[] { 1, 2, 3 },
//    new[] { 4, 5, 6 },
//    new[] { 7, 8, 9 }
//};
//Console.WriteLine("Rotate Image: ");
//Matrix.Rotate(mat);
//Console.WriteLine(string.Join("|", mat.Select(c => string.Join(",", c))));

//var mat2 = new int[][] {
//    new[] { 5, 1, 9, 11 },
//    new[] { 2, 4, 8, 10 },
//    new[] { 13, 3, 6, 7 },
//    new[] { 15, 14, 12, 16 }
//};
//Console.WriteLine("Rotate Image: ");
//Matrix.Rotate(mat2);
//Console.WriteLine(string.Join("|", mat2.Select(c => string.Join(",", c))));

//var mat3 = new int[][] {
//    new[] { 5, 1 },
//    new[] { 2, 4 }
//};
//Console.WriteLine("Rotate Image: ");
//Matrix.Rotate(mat3);
//Console.WriteLine(string.Join("|", mat3.Select(c => string.Join(",", c))));

//var mat4 = new int[][] {
//    new[] { 5}
//};
//Console.WriteLine("Rotate Image: ");
//Matrix.Rotate(mat3);
//Console.WriteLine(string.Join("|", mat4.Select(c => string.Join(",", c))));

//Console.WriteLine("Ugly Number: ");
//Console.WriteLine(Maths.IsUglyOpt(6));
//Console.WriteLine(Maths.IsUglyOpt(1));
//Console.WriteLine(Maths.IsUglyOpt(14));
//Console.WriteLine(Maths.IsUglyOpt(23));
//Console.WriteLine(Maths.IsUglyOpt(16));
//Console.WriteLine(Maths.IsUglyOpt(17));
//Console.WriteLine(Maths.IsUglyOpt(-2147483648));

//Console.WriteLine("Ugly Number ||: ");
//Console.WriteLine(Maths.NthUglyNumber(10));

//Console.WriteLine("আক".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("ন".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("১".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("০".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("sdfsd".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("A".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("!".Any(c => c >= 0x0980 && c <= 0x09FF));
//Console.WriteLine("F".Any(c => c >= 0x0980 && c <= 0x09FF));

//Console.WriteLine("Longest Substring Without Repeating Characters: ");
//Console.WriteLine(HashTables.LengthOfLongestSubstring("abcabcbb"));
//Console.WriteLine(HashTables.LengthOfLongestSubstring("bbbbb"));
//Console.WriteLine(HashTables.LengthOfLongestSubstring("pwwkew"));

//Console.WriteLine("Repeated DNA Sequences: ");
//Console.WriteLine(String.Join(",", HashTables.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT")));
//Console.WriteLine(String.Join(",", HashTables.FindRepeatedDnaSequences("AAAAAAAAAAAAA")));
//Console.WriteLine(String.Join(",", HashTables.FindRepeatedDnaSequences("CCCCAAAAAGGGTTT")));

//Console.WriteLine("Minimum Size Subarray Sum: ");
//Console.WriteLine(HashTables.MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 }));
//Console.WriteLine(HashTables.MinSubArrayLen(4, new int[] { 1, 4, 4 }));
//Console.WriteLine(HashTables.MinSubArrayLen(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
//Console.WriteLine(HashTables.MinSubArrayLen(11, new int[] { 1, 2, 3, 4, 5 }));

//Console.WriteLine(HashTables.MinSubArrayLen2(7, new int[] { 2, 3, 1, 2, 4, 3 }));
//Console.WriteLine(HashTables.MinSubArrayLen2(4, new int[] { 1, 4, 4 }));
//Console.WriteLine(HashTables.MinSubArrayLen2(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
//Console.WriteLine(HashTables.MinSubArrayLen2(11, new int[] { 1, 2, 3, 4, 5}));

//Console.WriteLine("Contains Duplicate II: ");
//Console.WriteLine(HashTables.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
//Console.WriteLine(HashTables.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
//Console.WriteLine(HashTables.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));

//Console.WriteLine("Maximum consecutive one’s: ");
//Console.WriteLine(Arrays.MaxConsecutiveOnes(new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1 }));
//Console.WriteLine(Arrays.MaxConsecutiveOnes(new int[] { 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
//Console.WriteLine(Arrays.MaxConsecutiveOnes(new int[] { 0, 0 }));

//Console.WriteLine("Count of sub-strings with equal consecutive 0’s and 1’s: ");
//Console.WriteLine(StringArrays.CountSubstring("010011"));
//Console.WriteLine(StringArrays.CountSubstring("0001110010"));

//Console.WriteLine("Longest Substring with At Least K Repeating Characters: ");
//Console.WriteLine(StringArrays.LongestSubstring("aaabb", 3));
//Console.WriteLine(StringArrays.LongestSubstring("ababbc", 2));
//Console.WriteLine(StringArrays.LongestSubstring("aaabbcddeababab", 3));

//Console.WriteLine("Longest Repeating Character Replacement: ");
//Console.WriteLine(StringArrays.CharacterReplacement("ABAB", 2));
//Console.WriteLine(StringArrays.CharacterReplacement("AABABBA", 1));

//Console.WriteLine("Maximum Average Subarray I: ");
//Console.WriteLine(StringArrays.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4));
//Console.WriteLine(StringArrays.FindMaxAverage(new int[] { 5 }, 1));
//Console.WriteLine(StringArrays.FindMaxAverage(new int[] { 0, 1, 1, 3, 3 }, 4));

//Console.WriteLine(StringArrays.FindMaxAverageOptimized(new int[] { 1, 12, -5, -6, 50, 3 }, 4));
//Console.WriteLine(StringArrays.FindMaxAverageOptimized(new int[] { 5 }, 1));
//Console.WriteLine(StringArrays.FindMaxAverageOptimized(new int[] { 0, 1, 1, 3, 3 }, 4));
//Console.WriteLine(StringArrays.FindMaxAverageOptimized(new int[] { 8860, -853, 6534, 4477, -4589, 8646, 
//    -6155, -5577, -1656, -5779, -2619, -8604, -1358, -8009, 4983, 7063, 3104, -1560, 4080, 2763, 5616, 
//    -2375, 2848, 1394, -7173, -5225, -8244, -809, 8025, -4072, -4391, -9579, 1407, 6700, 2421, -6685, 5481, 
//    -1732, -8892, -6645, 3077, 3287, -4149, 8701, -4393, -9070, -1777, 2237, -3253, -506, -4931, -7366, 
//    -8132, 5406, -6300, -275, -1908, 67, 3569, 1433, -7262, -437, 8303, 4498, -379, 3054, -6285, 4203, 
//    6908, 4433, 3077, 2288, 9733, -8067, 3007, 9725, 9669, 1362, -2561, -4225, 5442, -9006, -429, 160, 
//    -9234, -4444, 3586, -5711, -9506, -79, -4418, -4348, -5891 }, 93));

//Console.WriteLine("Find All Anagrams in a String: ");
//Console.WriteLine(String.Join(",", HashTables.FindAnagrams("cbaebabacd", "abc")));
//Console.WriteLine(String.Join(",", HashTables.FindAnagrams("abab", "ab")));
//Console.WriteLine(String.Join(",", HashTables.FindAnagrams("baa", "aa")));
//Console.WriteLine(String.Join(",", HashTables.FindAnagrams("ababababab", "aab")));

//Console.WriteLine("Find the K-Beauty of a Number: ");
//Console.WriteLine(StringArrays.DivisorSubstrings(240, 2));
//Console.WriteLine(StringArrays.DivisorSubstrings(430043, 2));
//Console.WriteLine(StringArrays.DivisorSubstrings(50000, 3));
//Console.WriteLine(StringArrays.DivisorSubstrings(500500, 3));

//Console.WriteLine("Longest Nice Substring: ");
//Console.WriteLine(StringRecursions.LongestNiceSubstring("YazaAay"));
//Console.WriteLine(StringRecursions.LongestNiceSubstring("abABB"));
//Console.WriteLine(StringRecursions.LongestNiceSubstring("Bb"));
//Console.WriteLine(StringRecursions.LongestNiceSubstring("c"));

//Console.WriteLine("Substrings of Size Three with Distinct Characters: ");
//Console.WriteLine(HashTables.CountGoodSubstrings("xyzzaz"));
//Console.WriteLine(HashTables.CountGoodSubstrings("aababcabc"));

//Console.WriteLine("Minimum Difference Between Highest and Lowest of K Scores: ");
//Console.WriteLine(StringArrays.MinimumDifference(new int[] { 90 }, 1));
//Console.WriteLine(StringArrays.MinimumDifference(new int[] { 9, 4, 1, 7 }, 2));

//Console.WriteLine("Minimum Recolors to Get K Consecutive Black Blocks: ");
//Console.WriteLine(StringArrays.MinimumRecolors("WBBWWBBWBW", 7));
//Console.WriteLine(StringArrays.MinimumRecolors("WBWBBBW", 2));
//Console.WriteLine(StringArrays.MinimumRecolors("BBBBBBB", 2));
//Console.WriteLine(StringArrays.MinimumRecolors("BBBBBBBW", 8));
//Console.WriteLine(StringArrays.MinimumRecolors("BBBBBBBW", 7));
//Console.WriteLine(StringArrays.MinimumRecolors("BBBBBBBW", 2));
//Console.WriteLine(StringArrays.MinimumRecolors("BBBWBBBW", 1));
//Console.WriteLine(StringArrays.MinimumRecolors("BBWWBBBW", 2));

//Console.WriteLine("Minimum Recolors to Get K Consecutive Black Blocks: ");
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 3, 2, 5, 4 }, 5));
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 1, 2 }, 2));
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 2, 3, 4, 5 }, 4));
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 2, 3, 4, 5 }, 5));
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 7, 3, 4, 5, 6, 8 }, 6));
//Console.WriteLine(StringArrays.LongestAlternatingSubarray(new int[] { 4, 10, 3 }, 10));

//Console.WriteLine("Maximum Points You Can Obtain from Cards: ");
//Console.WriteLine(StringArrays.MaxScore(new int[] { 1, 2, 3, 4, 5, 6, 1 }, 3));
//Console.WriteLine(StringArrays.MaxScore(new int[] { 2, 2, 2 }, 2));
//Console.WriteLine(StringArrays.MaxScore(new int[] { 9, 7, 7, 9, 7, 7, 9 }, 7));
//Console.WriteLine(StringArrays.MaxScore(new int[] { 11, 49, 100, 20, 86, 29, 72 }, 4));

//Console.WriteLine("Binary Tree Traversal: ");
//var tree1 = new TreeNode(1);
//tree1.left = new TreeNode(2);
//tree1.right = new TreeNode(3);
//tree1.left.left = new TreeNode(4);
//tree1.left.right = new TreeNode(5);
//Console.WriteLine(string.Join(",", Tree.InorderTraversal(tree1)));
//Console.WriteLine(string.Join(",", Tree.PreorderTraversal(tree1)));
//Console.WriteLine(string.Join(",", Tree.PostorderTraversal(tree1)));

//var tree2 = new TreeNode(1);
//tree2.right = new TreeNode(2);
//tree2.right.left = new TreeNode(3);
//Console.WriteLine(string.Join(",", Tree.InorderTraversal(tree2)));
//Console.WriteLine(string.Join(",", Tree.PreorderTraversal(tree2)));
//Console.WriteLine(string.Join(",", Tree.PostorderTraversal(tree2)));

//Console.WriteLine("Same Tree: ");
//var tree1 = new TreeNode(1);
//tree1.left = new TreeNode(2);
//tree1.right = new TreeNode(3);
//var tree2 = new TreeNode(1);
//tree2.left = new TreeNode(2);
//tree2.right = new TreeNode(3);
//Console.WriteLine(Tree.IsSameTree(tree1, tree2));

//var tree3 = new TreeNode(1);
//tree3.left = new TreeNode(2);
//var tree4 = new TreeNode(1);
//tree4.right = new TreeNode(2);
//Console.WriteLine(Tree.IsSameTree(tree3, tree4));

//Console.WriteLine("Symmetric Tree: ");
//var tree1 = new TreeNode(1);
//tree1.left = new TreeNode(2);
//tree1.right = new TreeNode(2);
//tree1.left.left = new TreeNode(3);
//tree1.left.right = new TreeNode(4);
//tree1.right.left = new TreeNode(4);
//tree1.right.right = new TreeNode(3);

//var tree2 = new TreeNode(1);
//tree2.left = new TreeNode(2);
//tree2.right = new TreeNode(2);
//tree2.left.right = new TreeNode(3);
//tree2.right.right = new TreeNode(3);

//Console.WriteLine(Tree.IsSymmetric(tree1));
//Console.WriteLine(Tree.IsSymmetric(tree2));

//Console.WriteLine("200. Number of Islands: ");
//var grid1 = new char[][]{
//    new []{'1', '1', '1', '1', '0' },
//    new []{ '1', '1', '0', '1', '0'},
//    new []{ '1', '1', '0', '0', '0'},
//    new []{ '0', '0', '0', '0', '0'}
//  };
//Console.WriteLine(NumberOfIslands.NumIslands(grid1));

//var grid2 = new char[][]{
//    new []{'1', '1', '0', '0', '0' },
//    new []{ '1', '1', '0', '0', '0'},
//    new []{ '0', '0', '1', '0', '0'},
//    new []{ '0', '0', '0', '1', '1'}
//  };
//Console.WriteLine(NumberOfIslands.NumIslands(grid2));

//Console.WriteLine("733. Flood Fill: ");
//var image1 = new int[][]{
//    new []{1, 1, 1 },
//    new []{ 1, 1, 0},
//    new []{ 1, 0, 1}
//  };
//Console.WriteLine(string.Join("\n", FloodFills.FloodFill(image1, 1, 1, 2).Select(i => string.Join(", ", i))));

//Console.WriteLine("733. Flood Fill: ");
//var image2 = new int[][]{
//    new []{0, 0, 0 },
//    new []{ 0, 0, 0}
//  };
//Console.WriteLine(string.Join("\n", FloodFills.FloodFill(image2, 0, 0, 0).Select(i => string.Join(", ", i))));

//var i5 = new ListNode(5);
//var i4 = new ListNode(4, i5);
//var i3 = new ListNode(3, i4);
//var i2 = new ListNode(2, i3);
//var i1 = new ListNode(1, i2);

//var i7 = new ListNode(7);
//var i6 = new ListNode(6, i7);

//Console.WriteLine("206. Reverse Linked List: ");
//PalindromeLinkList.PrintList(ReverseLinkList.ReverseList(i1));
//PalindromeLinkList.PrintList(ReverseLinkList.ReverseList(i6));

Console.ReadKey(true);



//static int calculateCost(List<int> arr, int threshold)
//{
//    var costDp = new int[arr.Count,threshold + 1];

//    //initialize DP with max value
//    for (int x = 0; x < arr.Count; x++)
//    {
//        for (int y = 0; y < threshold + 1; y++)
//        {
//            costDp[x,y] = int.MaxValue;
//        }
//    }        

//    //calculate DP for each cell
//    for (var i = 0; i < arr.Count; i++)
//    {
//        for (int j = 1; j <= threshold; j++)
//        {
//            costDp[i, j] = arr.Skip(j - 1).Take(j).Max();
//        }
//    }

//    var minCost = int.MaxValue;

//    for (var i = 0; i < arr.Count; i++)
//    {
//        var size= 1;
//        var costSum = 0;
//        while (size <= arr.Count)
//        {
//            costSum += costDp[i, size];
//            size++;
//        }
//        minCost = Math.Min(minCost, costSum);
//    }

//    return minCost;
//}