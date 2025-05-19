namespace ToolBox;

public class Screwdriver : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Screwdriver() : base("Screwdriver", "5.5kg")
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
        Console.WriteLine("Screwdriver is turning a screw!");
    }
}

