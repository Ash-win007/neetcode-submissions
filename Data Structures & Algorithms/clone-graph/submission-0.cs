/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    
    public Node CloneGraph(Node node) {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        return Dfs(node, oldToNew);
    }

    private Node Dfs(Node node, Dictionary<Node, Node> oldToNew) {
        // Base case: empty graph
        if (node == null)
            return null;

        // If we've already cloned this node, return the clone
        if (oldToNew.ContainsKey(node))
            return oldToNew[node];

        // Create a new node and store it in the map
        Node copy = new Node(node.val);
        oldToNew[node] = copy;

        // Recursively clone all neighbors
        foreach (Node nei in node.neighbors)
            copy.neighbors.Add(Dfs(nei, oldToNew));

        return copy;
    }
}