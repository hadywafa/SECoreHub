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
            result = InvertTree(root);
        Console.WriteLine(result);
    }

    public static TreeNode InvertTree(TreeNode root)
    {
        return new TreeNode();
    }
}
