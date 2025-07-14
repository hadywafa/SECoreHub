using System.IO.Pipelines;
using System.Net.Http.Headers;

namespace NeetCode.Trees;

public class P4
{
    // assume node is balanced
    static bool result = false;

    public static void Run()
    {
        int?[] rootArr = [1, 2, 2, 3, null, null, 3, 4, null, null, 4];
        var root = TreeNode.BuildTree(rootArr);

        var result = IsBalanced(root);
        Console.WriteLine(result);
    }

    public static bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;

        MaxDepth(root);
        return result;
    }

    public static int MaxDepth(TreeNode? root)
    {
        if (root == null)
            return 0;

        var depthLeft = MaxDepth(root.left);
        var depthRight = MaxDepth(root.right);

        // update max diameter at this node
        if (Math.Abs(depthLeft - depthRight) > 1)
            result = false;

        // return depth to parent
        return Math.Max(depthLeft, depthRight) + 1;
    }
}
