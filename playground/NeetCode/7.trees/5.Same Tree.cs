using System.IO.Pipelines;
using System.Net.Http.Headers;

namespace NeetCode.Trees;

public class P5
{
    public static void Run()
    {
        int?[] pArr = [1, 2, 3];
        // int?[] pArr = [2, 2, 2, null, 2, null, null, 2];
        int?[] qArr = [1, 2, 3];
        // int?[] qArr = [2, 2, 2, 2, null, 2, null];
        var p = TreeNode.BuildTree(pArr);
        var q = TreeNode.BuildTree(qArr);

        var isTheSame = IsSameTree(p, q);
        Console.WriteLine(isTheSame);
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
