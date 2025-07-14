namespace NeetCode.Trees;

public class P3
{
    public static void Run()
    {
        int?[] rootArr =
        [
            4,
            -7,
            -3,
            null,
            null,
            -9,
            -3,
            9,
            -7,
            -4,
            null,
            6,
            null,
            -6,
            -6,
            null,
            null,
            0,
            6,
            5,
            null,
            9,
            null,
            null,
            -1,
            -4,
            null,
            null,
            null,
            -2
        ];
        // int?[] rootArr = [4,-7,-3,null,null,-9,-3,9,-7,-4,null,6,null,-6,-6,null,null,0,6,5,null,9,null,null,-1,-4,null,null,null,-2];
        var root = TreeNode.BuildTree(rootArr);

        var result = DiameterOfBinaryTree(root);
        Console.WriteLine(result);
    }

    // 🤖
    public static int DiameterOfBinaryTree(TreeNode root)
    {
        int max = 0;
        Depth(root, ref max);
        return max;
    }

    static int Depth(TreeNode? node, ref int max)
    {
        if (node == null)
            return 0;

        int left = Depth(node.left, ref max);
        int right = Depth(node.right, ref max);

        // update max diameter at this node
        max = Math.Max(max, left + right);

        // return depth to parent
        return Math.Max(left, right) + 1;
    }
}
