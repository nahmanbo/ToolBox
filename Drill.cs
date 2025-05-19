namespace ToolBox;

public class Drill : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Drill() : base("Drill", "1.5kg")
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
        Console.WriteLine("Drill is making a hole!");
    }
}