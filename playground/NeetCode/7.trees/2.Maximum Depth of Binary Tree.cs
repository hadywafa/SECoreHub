namespace NeetCode.Trees;

public class P2
{
    public static void Run()
    {
        int?[] rootArr = [3, 9, 20, null, null, 15, 7];
        var root = TreeNode.BuildTree(rootArr);

        var result = MaxDepth_S2(root);
        Console.WriteLine(result);
    }

    public static int MaxDepth_S2(TreeNode? root)
    {
        if (root == null)
            return 0;

        var depthLeft = MaxDepth_S2(root.left);
        var depthRight = MaxDepth_S2(root.right);

        return Math.Max(depthLeft, depthRight) + 1;
    }

    public static int MaxDepth_S1(TreeNode? root)
    {
        if (root == null)
            return 0;

        var depthLeft = root.left != null ? MaxDepth_S1(root.left) + 1 : 1;
        var depthRight = root.right != null ? MaxDepth_S1(root.right) + 1 : 1;

        return Math.Max(depthLeft, depthRight);
    }
}
