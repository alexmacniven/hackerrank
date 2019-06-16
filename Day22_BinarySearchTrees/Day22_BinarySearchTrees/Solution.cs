using System;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{
    /*
     * The base case for this recursive method is when the supplied
     * node is null; an integer of -1 returned.
     * 
     * Looking at a diagram may simplify the logic;
     * 
     *         A
     *       /   \
     *      B     C
     *     / \   / \
     *    D   E F   G
     *               \
     *                H
     *
     * When Nodes D, E, F, H are supplied the getHeight of their
     * child nodes return -1 values and the recursive function
     * starts to 'whind-up'.
     * 
     * Using H as an example; 
     * 1. H returns a 0 (1 + Max(-1, -1))
     * 2. G returns a 1 (1 + Max(-1, 0))
     * 3. C returns a 2 (1 + Max(0, 1))
     * 4. A returns a 3 (1 + Max(1, 2))
     */
    static int getHeight(Node root)
    {
        if(root == null)
        {
            return -1;
        } else
        {
            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);
        Console.ReadLine();

    }
}