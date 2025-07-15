namespace LeetCode;

public class P98
{
    static bool isValidBST = true;
    public static void Run()
    {
        // int?[] rootArr = [2,1,3];
        // int?[] rootArr = [5,1,4,null,null,3,6];
        // int?[] rootArr = [5, 4, 6, null, null, 3, 7];
        int?[] rootArr = [3, 1, 5, 0, 2, 4, 6];
        var root = TreeNode.BuildTree(rootArr);


        var result = IsValidBST_New(root, long.MinValue, long.MaxValue);
        Console.WriteLine(result);
    }


    public static bool IsValidBST_New(TreeNode? node, long min, long max)
    {
        if (node == null)
            return true;

        if (node.val <= min || node.val >= max)
            return false;

        return IsValidBST_New(node.left, min, node.val ?? long.MaxValue) &&
               IsValidBST_New(node.right, node.val ?? long.MinValue, max);
    }

    //--------------------------------------------------------------------------

    // This only checks the immediate child, but not the entire subtree.
    // if (root.left != null && root.left.val >= root.val)
    public static bool IsValidBST_Old(TreeNode? root)
    {
        if (root == null)
            return isValidBST;

        if (!IsValidBST_Old(root.left) || !IsValidBST_Old(root.right))
            isValidBST = false;



        if (root.left != null && root.left.val >= root.val)
            isValidBST = false;
        if (root.right != null && root.right.val <= root.val)
            isValidBST = false;

        return isValidBST;
    }

}
