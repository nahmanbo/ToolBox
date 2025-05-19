namespace ToolBox;

public class PipeCutter : Tool
{
    //====================================
    //           Constructor
    //====================================
    public PipeCutter() : base("PipeCutter", "3.5kg")
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
        Console.WriteLine("PipeCutter is slicing a pipe!");
    }
}
