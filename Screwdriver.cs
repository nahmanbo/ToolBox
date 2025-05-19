namespace ToolBox;

public class Screwdriver : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Screwdriver() : base("Screwdriver", "1.5kg")
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
        Console.WriteLine("The screwdriver is currently in use");
    }
}

