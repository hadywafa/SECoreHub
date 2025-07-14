namespace NeetCode.Trees;

public class P3
{
    public static void Run()
    {

        int?[] rootArr = [4,-7,-3,null,null,-9,-3,9,-7,-4,null,6,null,-6,-6,null,null,0,6,5,null,9,null,null,-1,-4,null,null,null,-2];
        // int?[] rootArr = [4,-7,-3,null,null,-9,-3,9,-7,-4,null,6,null,-6,-6,null,null,0,6,5,null,9,null,null,-1,-4,null,null,null,-2];
        var root = TreeNode.BuildTree(rootArr);

        var result = DiameterOfBinaryTree(root);
        Console.WriteLine(result);
    }

    public static int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null)
            return 0;


        var depthLeft = root.left != null ? MaxDepth(root.left) : 0;
        var depthRight = root.right != null ? MaxDepth(root.right) : 0;

        return depthLeft + depthRight;

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
