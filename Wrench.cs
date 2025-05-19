namespace ToolBox;

public class Wrench : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Wrench() : base("Wrench", "1.5kg")
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
        Console.WriteLine("The wrench is currently in use");
    }
}