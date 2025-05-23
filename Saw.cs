namespace ToolBox;

public class Saw : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Saw() : base("Saw", "4.5kg")
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
        Console.WriteLine("Saw is cutting through wood!");
    }
}