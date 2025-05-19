namespace ToolBox;

public class Wrench : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Wrench() : base("Wrench", "6.5kg")
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
        Console.WriteLine("Wrench is tightening a bolt!");
    }
}