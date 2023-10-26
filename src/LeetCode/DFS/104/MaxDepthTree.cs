using LeetCode.DFS._100;

namespace LeetCode.DFS._104;

public class MaxDepthTree
{
    public static void Run()
    {
        Console.WriteLine("104. Maximum Depth of Binary Tree: ");
        var tree1 = new TreeNode(3);
        tree1.left = new TreeNode(9);
        tree1.right = new TreeNode(20);
        tree1.right.left = new TreeNode(15);
        tree1.right.right = new TreeNode(7);

        Console.WriteLine(MaxDepthTree.MaxDepth(tree1));
    }

    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
