namespace ChessOpeningDictionary.API.Domain;

public class OpeningTree
{
    private Node root;

    public OpeningTree()
    {
        root = new Node("");
    }

    public void AddOpening(string moves, string opening)
    {
        Node node = root;

        foreach (char move in moves)
        {
            node = node.GetChild(move);
        }

        node.Openings.Add(opening);
    }

    public List<string> GetPossibleOpenings(string moves)
    {
        Node node = root;

        foreach (char move in moves)
        {
            node = node.GetChild(move);

            if (node == null)
            {
                return new List<string>();
            }
        }

        return node.Openings;
    }

    private class Node
    {
        private Dictionary<char, Node> children;
        public List<string> Openings { get; }

        public Node(string opening)
        {
            children = new Dictionary<char, Node>();
            Openings = new List<string> { opening };
        }

        public Node GetChild(char move)
        {
            if (!children.ContainsKey(move))
            {
                children.Add(move, new Node(null));
            }

            return children[move];
        }
    }

}
