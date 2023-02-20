using System.Text;

namespace bl.Structures;
public class BinarySearchTree
{
    private Node _root { get; set; }

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Add(int value)
    {
        _root = Add(_root, value);
    }

    public string PreOrder()
    {
        return $"Pre-orden: {PreOrder(_root, new StringBuilder())}";
    }

    public string InOrder()
    {
        return $"In-orden: {InOrder(_root, new StringBuilder())}";
    }

    public string PostOrder()
    {
        return $"Post-orden: {PostOrder(_root, new StringBuilder())}";
    }

    public string Draw()
    {
        return $"{Draw(_root, stringBuilder: new StringBuilder())}";
    }

    private Node Add(Node aux, int value)
    {
        if (aux == null)
        {
            return new Node()
            {
                Value = value,
            };
        }

        if (aux.Value > value)
        {
            aux.Left = Add(aux.Left, value);
        }
        else if (aux.Value < value)
        {
            aux.Right = Add(aux.Right, value);
        }
        else
        {
            return aux;
        }

        aux.UpdateHeightAndBalanceFactor();

        if (aux.BalanceFactor > 1 && aux.Right.BalanceFactor > 0)
        {
            aux = LeftRotate(aux);
        }
        if (aux.BalanceFactor < -1 && aux.Left.BalanceFactor < 0)
        {
            aux = RightRotate(aux);
        }

        if (aux.BalanceFactor > 1 && aux.Right.BalanceFactor < 0)
        {
            aux.Right = RightRotate(aux.Right);
            aux = LeftRotate(aux);
        }
        if (aux.BalanceFactor < -1 && aux.Left.BalanceFactor > 0)
        {
            aux.Left = LeftRotate(aux.Left);
            aux = RightRotate(aux);
        }

        return aux;
    }

    private Node LeftRotate(Node p)
    {
        var q = p.Right;
        p.Right = q.Left;
        q.Left = p;

        p.UpdateHeightAndBalanceFactor();
        q.UpdateHeightAndBalanceFactor();

        return q;
    }

    private Node RightRotate(Node p)
    {
        var q = p.Left;
        p.Left = q.Right;
        q.Right = p;

        p.UpdateHeightAndBalanceFactor();
        q.UpdateHeightAndBalanceFactor();

        return q;
    }

    private StringBuilder PreOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        stringBuilder.Append($"{aux.Value}, ");
        PreOrder(aux.Left, stringBuilder);
        PreOrder(aux.Right, stringBuilder);

        return stringBuilder;
    }

    private StringBuilder InOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        InOrder(aux.Left, stringBuilder);
        stringBuilder.Append($"{aux.Value}, ");
        InOrder(aux.Right, stringBuilder);

        return stringBuilder;
    }

    private StringBuilder PostOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        PostOrder(aux.Left, stringBuilder);
        PostOrder(aux.Right, stringBuilder);
        stringBuilder.Append($"{aux.Value}, ");

        return stringBuilder;
    }

    private StringBuilder Draw(Node node, int level = 0, StringBuilder stringBuilder = null)
    {
        if (node == null)
        {
            return stringBuilder;
        }

        Draw(node.Right, level + 1, stringBuilder);

        for (int i = 0; i < level; i++)
        {
            stringBuilder.Append("    ");
        }

        stringBuilder.Append($"{node.Value}\n");

        Draw(node.Left, level + 1, stringBuilder);

        return stringBuilder;
    }
}