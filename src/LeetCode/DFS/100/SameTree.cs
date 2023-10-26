namespace LeetCode.DFS._100;

public class SameTree
{
    public static void Run()
    {
        Console.WriteLine("100. Same Tree: ");
        var tree1 = new TreeNode(1);
        tree1.left = new TreeNode(2);
        tree1.right = new TreeNode(3);
        var tree2 = new TreeNode(1);
        tree2.left = new TreeNode(2);
        tree2.right = new TreeNode(3);
        Console.WriteLine(SameTree.IsSameTree(tree1, tree2));
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
