namespace NeetCode.Trees;

// ❌
public class P6
{
    static bool result = false;

    public static void Run()
    {
        int?[] pArr = [3, 4, 5, 1, 2];
        // int?[] pArr = [2, 2, 2, null, 2, null, null, 2];
        int?[] qArr = [4, 1, 2];
        // int?[] qArr = [2, 2, 2, 2, null, 2, null];
        var p = TreeNode.BuildTree(pArr);
        var q = TreeNode.BuildTree(qArr);

        var isSubtree = IsSubtree(p, q);
        Console.WriteLine(isSubtree);
    }

    public static bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
            return false;

        if (IsSameTree(root, subRoot))
            return true;

        // Check left and right subtree
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null || q == null)
            return p == null && q == null;

        if (p.val != q.val || !IsSameTree(p.left, q.left) || !IsSameTree(p.right, q.right))
            return false;

        return p.val == q.val && p.left?.val == q.left?.val && p.right?.val == q.right?.val;
    }
}
