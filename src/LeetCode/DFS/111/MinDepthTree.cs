namespace LeetCode.DFS._111;

public class MinDepthTree
{
    public static void Run()
    {
        Console.WriteLine("111. Minimum Depth of Binary Tree: ");
        var tree1 = new TreeNode(3);
        tree1.left = new TreeNode(9);
        tree1.right = new TreeNode(20);
        tree1.right.left = new TreeNode(15);
        tree1.right.right = new TreeNode(7);

        Console.WriteLine(MinDepthTree.MinDepth(tree1));
    }

    public static int MinDepth(TreeNode root)
    {
        if (root == null) return 0;

        if (root.left == null)
            return 1 + MinDepth(root.right);
        else if (root.right == null)
            return 1 + MinDepth(root.left);

        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}
