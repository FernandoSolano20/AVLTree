using bl.Structures;

namespace bl;
public class Business
{
    private readonly BinarySearchTree _tree;
    public Business()
    {
        _tree = new BinarySearchTree();
    }

    public void Add(int value)
    {
        _tree.Add(value);
    }

    public string ShowPreOrder()
    {
        return _tree.PreOrder();
    }

    public string ShowInOrder()
    {
        return _tree.InOrder();
    }

    public string ShowPostOrder()
    {
        return _tree.PostOrder();
    }

    public string ShowTree()
    {
        return $"{ShowPreOrder()} \n{ShowInOrder()} \n{ShowPostOrder()}";
    }

    public string DrawTree()
    {
        return _tree.Draw();
    }
}