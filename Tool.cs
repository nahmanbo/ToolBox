namespace ToolBox;

public class Tool
{
    protected String _name;
    protected String _weight;

    public Tool(String name, String weight)
    {
        _name = name;
        _weight = weight;
    }

    public void Describe()
    {
        Console.WriteLine($"{_name} {_weight}");
    }

    public void Use()
    {
        Console.WriteLine($"Tool is being used");
    }
}