namespace LeetCode.DFS._101;

public class SymmetricTree
{
    public static void Run()
    {
        Console.WriteLine("101. Symmetric Tree: ");
        var tree1 = new TreeNode(1);
        tree1.left = new TreeNode(2);
        tree1.right = new TreeNode(2);
        tree1.left.left = new TreeNode(3);
        tree1.left.right = new TreeNode(4);
        tree1.right.left = new TreeNode(4);
        tree1.right.right = new TreeNode(3);

        var tree2 = new TreeNode(1);
        tree2.left = new TreeNode(2);
        tree2.right = new TreeNode(2);
        tree2.left.right = new TreeNode(3);
        tree2.right.right = new TreeNode(3);

        Console.WriteLine(SymmetricTree.IsSymmetric(tree1));
        Console.WriteLine(SymmetricTree.IsSymmetric(tree2));
    }

    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null)
            return true;

        return IsSymmetricPart(root.left, root.right);
    }

    private static bool IsSymmetricPart(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        if (p.val != q.val)
            return false;

        return IsSymmetricPart(p.left, q.right)
            && IsSymmetricPart(p.right, q.left);
    }
}
