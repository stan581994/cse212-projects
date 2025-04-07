public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1 - Only insert unique values
        
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value equals Data, do nothing (don't insert duplicates)
    }

    public bool Contains(int value)
    {
        // Problem 2 - Check if the tree contains a value
        
        // If the value equals the current node's data, we found it
        if (value == Data)
            return true;
            
        // If the value is less than the current node's data, search in the left subtree
        if (value < Data)
            return Left != null && Left.Contains(value);
            
        // If the value is greater than the current node's data, search in the right subtree
        return Right != null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // Base case: height of a node with no children is 1
        int leftHeight = Left == null ? 0 : Left.GetHeight();
        int rightHeight = Right == null ? 0 : Right.GetHeight();
        
        // Return 1 (for this node) plus the maximum height of left or right subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
