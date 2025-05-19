namespace ToolBox;

public abstract class Tool
{
    protected string _name;
    protected string _weight;

    //====================================
    //           Constructor
    //====================================
    public Tool(string name, string weight)
    {
        _name = name;
        _weight = weight;
    }

    //====================================
    //           Methods
    //====================================
    public abstract void Describe(); 
    public abstract void Use();
}