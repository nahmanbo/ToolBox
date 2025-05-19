namespace ToolBox;

public class Saw : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Saw() : base("Saw", "1.5kg")
    {
    }
    
    //====================================
    //           Methods
    //====================================
    public override void Describe()
    {
        Console.WriteLine($"{_name} has {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("The saw is currently in use");
    }
}