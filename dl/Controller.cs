using bl;

namespace dl;
public class Controller
{
    private readonly Business _bl;
    public Controller()
    {
        _bl = new Business();
    }

    public void Add(int value)
    {
        _bl.Add(value);
    }

    public string ShowPreOrder()
    {
        return _bl.ShowPreOrder();
    }

    public string ShowInOrder()
    {
        return _bl.ShowInOrder();
    }

    public string ShowPostOrder()
    {
        return _bl.ShowPostOrder();
    }

    public string ShowTree()
    {
        return _bl.ShowTree();
    }

    public string DrawTree()
    {
        return _bl.DrawTree();
    }
}