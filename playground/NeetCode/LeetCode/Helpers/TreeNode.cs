using System.Runtime.InteropServices;

namespace LeetCode;

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

    /// <summary>
    /// Builds a binary tree from an array representation, using a
    /// level-order traversal approach.
    /// </summary>
    /// <param name="arr">The array to build the tree from.</param>
    /// <returns>The root of the constructed tree.</returns>
    /// <remarks>
    /// The array is interpreted as follows:
    /// <list type="number">
    /// <item> The first element is the root of the tree.</item>
    /// <item> The second element is the left child of the root.</item>
    /// <item> The third element is the right child of the root.</item>
    /// <item> The fourth element is the left child of the second element.</item>
    /// <item> The fifth element is the right child of the second element.</item>
    /// <item> The sixth element is the left child of the third element.</item>
    /// <item> The seventh element is the right child of the third element.</item>
    /// <item> And so on.</item>
    /// </list>
    /// </remarks>
    public static TreeNode? BuildTree(int?[] arr)
    {
        // int?[] arr = new int?[] { 1, 2, 3, null, 4, 5, 6 };
        //----------------------------------------------------------
        // 🚫 Step 1: Handle edge cases
        if (arr == null)
            throw new NullReferenceException("Your array is null");

        if (arr.Length == 0 || arr[0] == null)
            return null;

        // 🌱 Step 2: Create the root node
        TreeNode root = new TreeNode(arr[0]);

        // 📦 Step 3: Use a queue to connect children level by level
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1; // index in the array

        // 🚶‍♂️ Step 4: Loop over array to build the tree
        while (i < arr.Length)
        {
            TreeNode current = queue.Dequeue(); // Get parent node from queue

            // 👶 Try to add left child
            if (i < arr.Length && arr[i] != null)
            {
                TreeNode leftChild = new TreeNode(arr[i]);
                current.left = leftChild;
                queue.Enqueue(leftChild); // enqueue to attach its children later
            }
            i++;

            // 👶 Try to add right child
            if (i < arr.Length && arr[i] != null)
            {
                TreeNode rightChild = new TreeNode(arr[i]);
                current.right = rightChild;
                queue.Enqueue(rightChild);
            }
            i++;
        }

        return root;
    }
}
