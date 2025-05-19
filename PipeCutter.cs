namespace ToolBox;

public class PipeCutter : Tool
{
    //====================================
    //           Constructor
    //====================================
    public PipeCutter() : base("PipeCutter", "1.5kg")
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
        Console.WriteLine("The pipeCutter is currently in use");
    }
}
