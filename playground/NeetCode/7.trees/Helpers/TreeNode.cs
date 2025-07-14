using System.Runtime.InteropServices;

namespace NeetCode.Trees;

//   Definition for a binary tree node.
public class TreeNode
{
    public int? val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int? val = null, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode? BuildTree(int?[] arr)
    {
        if (arr == null)
            throw new NullReferenceException("You Array is Null");

        if (arr.Length == 0 || arr[0] == null)
            return null;

        TreeNode root = new TreeNode(arr[0]);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1;

        while (i < arr.Length)
        {
            TreeNode current = queue.Dequeue();

            if (i < arr.Length && arr[i] != null)
            {
                current.left = new TreeNode(arr[i]);
                queue.Enqueue(current.left);
            }
            i++;

            if (i < arr.Length && arr[i] != null)
            {
                current.right = new TreeNode(arr[i]);
                queue.Enqueue(current.right);
            }
            i++;
        }

        return root;
    }
}
