namespace ToolBox;

public class WireStripper : Tool
{
    //====================================
    //           Constructor
    //====================================
    public WireStripper() : base("WireStripper", "3.5kg")
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
        Console.WriteLine("WireStripper is removing insulation from a wire!");
    }
}