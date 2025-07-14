namespace NeetCode.Trees;

public class P1
{
    public static void Run()
    {
        int?[] rootArr = [4, 2, 7, 1, 3, 6, 9];
        var root = TreeNode.BuildTree(rootArr);

        TreeNode? result;
        if (root == null)
            result = root;
        else
            result = InvertTree_S1(root);
        Console.WriteLine(result);
    }

    public static TreeNode InvertTree_S1(TreeNode root)
    {
        InvertTree(root);
        return root;
    }

    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
            return null;
        // 🔄 Swap children
        TreeNode? temp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);

        return root;
    }    
}
