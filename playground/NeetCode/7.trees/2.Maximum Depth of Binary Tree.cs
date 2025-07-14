namespace NeetCode.Trees;

public class P2
{
    public static void Run()
    {
        
        int?[] rootArr = [3,9,20,null,null,15,7];
        var root = TreeNode.BuildTree(rootArr);
 
        var result = MaxDepth(root);
        Console.WriteLine(result);
     }

    public static int MaxDepth(TreeNode? root)
    {
        if (root == null)
            return 0;

        var depthLeft = root.left != null ? MaxDepth(root.left) + 1 : 1;
        var depthRight = root.right != null ? MaxDepth(root.right) + 1 : 1;

        return Math.Max(depthLeft, depthRight);
    }
}
